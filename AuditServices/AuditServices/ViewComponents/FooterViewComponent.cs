using System.Linq;
using System.Threading.Tasks;
using AuditServices.DAL;
using AuditServices.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuditServices.ViewComponents
{
    public class FooterViewComponent: ViewComponent
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public FooterViewComponent(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_mapper.Map<FooterVM>(
                await _context.Footers
                .Include(f=>f.FooterParts.OrderBy(fp=>fp.Order))
                .ThenInclude(fp=>fp.FooterPartLinks)
                .FirstOrDefaultAsync()
                ));
        }
    }
}
