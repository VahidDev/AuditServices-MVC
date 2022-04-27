using System.Collections.Generic;

namespace AuditServices.ViewModels
{
    public class HomePageVM
    {
        public ICollection<HomePageCardVM> Cards { get; set; }
        public HomePageTrendingSectionVM TrendingSection { get; set; }
    }
}
