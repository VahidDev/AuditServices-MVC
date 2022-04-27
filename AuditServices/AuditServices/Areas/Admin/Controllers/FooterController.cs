using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditServices.Constants.PocoConstants;
using AuditServices.DAL;
using AuditServices.Models.Pages;
using AuditServices.ViewModels;
using AuditServices.ViewModels.AdminVMs.PageVMs.FooterVMs;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuditServices.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = DefaultRoleConstants.Admin + "," + DefaultRoleConstants.Moderator)]
    public class FooterController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public FooterController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<FooterVM>
                (await _context.Footers
                .Include(f=>f.FooterParts.OrderBy(fp=>fp.Order))
                .ThenInclude(fp=>fp.FooterPartLinks)
                .FirstOrDefaultAsync()));
        }
        [HttpGet]
        public async Task<IActionResult> Update()
        {
            return View(_mapper.Map<FooterUpdateVM>
                (await _context.Footers
                .FirstOrDefaultAsync()));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(FooterUpdateVM model)
        {
            if (!ModelState.IsValid) return View(model);
            Footer footer = await _context.Footers.FirstOrDefaultAsync();
            footer.LinkedInLink = model.LinkedInLink;
            footer.TwitterLink = model.TwitterLink;
            footer.YoutubeLink = model.YoutubeLink;
            footer.InstagramLink = model.InstagramLink;
            footer.Content = model.Content;
            _context.Footers.Update(footer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> UpdatePart(int id)
        {
            return View(_mapper.Map<FooterPartUpdateVM>(await _context.FooterParts
                .Include(fp=>fp.FooterPartLinks).OrderBy(fp=>fp.Order)
                .FirstOrDefaultAsync(fp=>fp.Id==id&&!fp.IsDeleted)));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdatePart(FooterPartUpdateVM model)
        {
                if (!ModelState.IsValid) return View(model);
                FooterPart footerPart = await _context.FooterParts
                    .FirstOrDefaultAsync(fp => fp.Id == model.Id && !fp.IsDeleted);
                footerPart.Order = model.Order;
                footerPart.Title = model.Title;
                footerPart.FooterPartLinks = _mapper
                    .Map<List<FooterPartLink>>(model.FooterPartLinks);
                _context.FooterParts.Update(footerPart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
        }
    }
}
