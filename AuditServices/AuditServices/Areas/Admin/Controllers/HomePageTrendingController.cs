using System;
using System.Linq;
using System.Threading.Tasks;
using AuditServices.Constants.MessageConstants;
using AuditServices.Constants.PocoConstants;
using AuditServices.DAL;
using AuditServices.Models.Pages;
using AuditServices.Utilities.FileUtilities;
using AuditServices.ViewModels.AdminVMs.PageVMs.HomePageVMs;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuditServices.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = DefaultRoleConstants.Admin + "," + DefaultRoleConstants.Moderator)]
    public class HomePageTrendingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public HomePageTrendingController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.HomePageTrendingSections
                .Include(t=>t.Parts.OrderBy(p=>p.Order))
                .FirstOrDefaultAsync(t=>!t.IsDeleted));
        }
        [HttpGet]
        public async Task<IActionResult> Update()
        {
            HomePageTrendingSectionUpdateVM modelToSend = _mapper
                .Map<HomePageTrendingSectionUpdateVM>(await _context
                .HomePageTrendingSections
                .FirstOrDefaultAsync(t => !t.IsDeleted));
            return View(modelToSend);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(HomePageTrendingSectionUpdateVM model)
        {
            try
            {
                if (!ModelState.IsValid) return View(model);
                HomePageTrendingSection section = await _context.HomePageTrendingSections
                    .FirstOrDefaultAsync(p => p.Id == model.Id);
                section.Description = model.Description;
                section.Title = model.Title;
                section.Tag = model.Tag;
                if (model.NewImage != null)
                {
                    if (!model.NewImage.IsImg())
                    {
                        ModelState.AddModelError(nameof(HomePageTrendingSectionUpdateVM.NewImage),
                            FileMessageConstants.ImageContentError);
                        return View(model);
                    }
                    if (!model.NewImage.CheckSizeForMg())
                    {
                        ModelState.AddModelError(nameof(HomePageTrendingSectionUpdateVM.NewImage),
                            FileMessageConstants.MgSizeError);
                        return View(model);
                    }
                    FileDeleter.Delete(FileNameConstants.Image, section.Image);
                    Guid guid = Guid.NewGuid();
                    await model.NewImage.CreateAsync(guid,FileNameConstants.Image);
                    section.Image = guid + model.NewImage.FileName;
                }
                _context.HomePageTrendingSections.Update(section);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(Index));
            }
        }
        [HttpGet]
        public async Task<IActionResult> UpdatePart(int id)
        {
            HomePageTrendingSectionPartUpdateVM modelToSend = _mapper
                .Map<HomePageTrendingSectionPartUpdateVM>(await _context
                .HomePageTrendingSectionParts
                .FirstOrDefaultAsync(p=> p.Id == id&&!p.IsDeleted));
            return View(modelToSend);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdatePart(HomePageTrendingSectionPartUpdateVM model)
        {
            try
            {
                if (!ModelState.IsValid) return View(model);
                HomePageTrendingSectionPart part = await _context.HomePageTrendingSectionParts
                    .FirstOrDefaultAsync(p => p.Id == model.Id&&!p.IsDeleted);
                if (part == null) return NotFound();
                part.Order = model.Order;
                part.Title = model.Title;
                part.Content = model.Content;
                _context.HomePageTrendingSectionParts.Update(part);
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
