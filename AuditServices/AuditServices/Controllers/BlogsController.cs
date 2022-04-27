using System;
using System.Linq;
using System.Threading.Tasks;
using AuditServices.Constants.MessageConstants;
using AuditServices.DAL;
using AuditServices.Models.Entities;
using AuditServices.Utilities.FileUtilities;
using AuditServices.ViewModels.BlogVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuditServices.Controllers
{
    [Authorize]
    public class BlogsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        public BlogsController
            (AppDbContext context,UserManager<User>userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(new BlogIndexVM { 
            Blogs=await _context.Blogs.Where(b => !b.IsDeleted)
            .Include(b=>b.User)
            .OrderByDescending(b=>b.CreatedDate)
            .ToListAsync()
            });
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            Blog blog = await _context.Blogs
                .FirstOrDefaultAsync(b=>b.Id==id&&!b.IsDeleted);
            if (blog == null) return NotFound();
            return View(new BlogUpdateVM
            {
                Description = blog.Description,
                CurrentImage=blog.Image,
                BlogId=blog.Id
            });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(BlogUpdateVM model)
        {
            try
            {
                if (!ModelState.IsValid) return View(model);
                Blog blog = await _context.Blogs
                .FirstOrDefaultAsync(b => b.Id == model.BlogId && !b.IsDeleted);
                if (blog == null) return NotFound();
                if (model.NewImage != null)
                {
                    if (!model.NewImage.IsImg())
                    {
                        ModelState.AddModelError(nameof(BlogUpdateVM.NewImage),
                            FileMessageConstants.ImageContentError);
                        return View(model);
                    }
                    if (!model.NewImage.CheckSizeForMg())
                    {
                        ModelState.AddModelError(nameof(BlogUpdateVM.NewImage),
                            FileMessageConstants.MgSizeError);
                        return View(model);
                    }
                    FileDeleter.Delete(FileNameConstants.Image, model.CurrentImage);
                    Guid guid = Guid.NewGuid();
                    await model.NewImage.CreateAsync(guid,FileNameConstants.Image);
                    blog.Image = guid + model.NewImage.FileName;
                }
                blog.Description = model.Description;
                _context.Blogs.Update(blog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AccountController.Index),
                    "Account");
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(AccountController.Index),
                    "Account");
            }
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            string image = "";
            if (User.Identity.IsAuthenticated)
            {
                image = (await _userManager.FindByNameAsync(User.Identity.Name)).Image;
            }
            return View(new BlogDetailsVM
            {
              Blog=await _context.Blogs
              .Include(b => b.User)
              .Include(b=>b.Comments.Where(c=>!c.IsDeleted).OrderBy(c=>c.CreatedDate))
              .ThenInclude(c=>c.User)
              .FirstOrDefaultAsync(b=>b.Id==id),
                Image=image
            });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogIndexVM model)
        {
            try
            {
                BlogIndexVM modelToSend = new()
                {
                    Blogs = await _context.Blogs.Include(b => b.User)
                    .Where(b => !b.IsDeleted).ToListAsync()
                };
                if (!ModelState.IsValid) return View(nameof(Index), modelToSend);
                BlogCreateVM createVM = model.BlogCreateVM;
                if (!createVM.Image.IsImg())
                {
                    ModelState.AddModelError("", FileMessageConstants.ImageContentError);
                    return View(nameof(Index), modelToSend);
                }
                if (!createVM.Image.CheckSizeForMg())
                {
                    ModelState.AddModelError("", FileMessageConstants.MgSizeError);
                    return View(nameof(Index), modelToSend);
                }
                Guid guid = Guid.NewGuid();
                await createVM.Image.CreateAsync(guid, FileNameConstants.Image);
                await _context.Blogs.AddAsync(new Blog { 
                    Description=createVM.Description,
                    Image=guid+createVM.Image.FileName,
                    User=await _userManager.FindByNameAsync(User.Identity.Name)
                });
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch(Exception)
            {
                return RedirectToAction(nameof(Index));
            }
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Blog blog = await _context.Blogs
                    .FirstOrDefaultAsync(b =>b.Id==id&& !b.IsDeleted);
                if (blog == null) return NotFound();
                blog.IsDeleted = true;
                blog.DeletedDate = DateTime.Now;
                FileDeleter.Delete(FileNameConstants.Image, blog.Image);
                _context.Blogs.Update(blog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception) 
            { 
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
