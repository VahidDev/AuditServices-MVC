using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditServices.DAL;
using AuditServices.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuditServices.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public HomeController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            return View(new HomePageVM { 
            Cards=_mapper.Map<List<HomePageCardVM>>
            (await _context.HomePageCards.ToListAsync()),
            TrendingSection= _mapper.Map<HomePageTrendingSectionVM>
            (await _context.HomePageTrendingSections
            .Include(t=>t.Parts.OrderBy(p=>p.Order))
            .FirstOrDefaultAsync())
            });
        }
    }
}
