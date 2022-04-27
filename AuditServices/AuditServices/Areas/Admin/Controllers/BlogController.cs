using System;
using System.Linq;
using System.Threading.Tasks;
using AuditServices.Constants.MessageConstants;
using AuditServices.Constants.PocoConstants;
using AuditServices.DAL;
using AuditServices.Models.Entities;
using AuditServices.Utilities.FileUtilities;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuditServices.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = DefaultRoleConstants.Admin + "," + DefaultRoleConstants.Moderator)]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public BlogController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Blogs
                .Where(b=>!b.IsDeleted).Include(b=>b.User)
                .ToListAsync());
        }
        public async Task<string>Delete(int id)
        {
            Blog blog = await _context.Blogs
                .FirstOrDefaultAsync(b => b.Id == id && !b.IsDeleted);
            if (blog == null) return "Not Found";
            FileDeleter.Delete(FileNameConstants.Image, blog.Image);
            blog.IsDeleted = true;
            blog.DeletedDate = DateTime.Now;
            _context.Blogs.Update(blog);
            await _context.SaveChangesAsync();
            return "Success";
        }
        [HttpGet]
        public async Task<IActionResult>Detail(int id)
        {
            Blog blog = await _context.Blogs
                .Include(b=>b.User).Include(b=>b.Comments.Where(c=>!c.IsDeleted))
                .ThenInclude(c=>c.User)
               .FirstOrDefaultAsync(b => b.Id == id && !b.IsDeleted);
            if (blog == null) return NotFound();
            return View(blog);
        }
    }
}
