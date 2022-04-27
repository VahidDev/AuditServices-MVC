using System.Collections.Generic;

namespace AuditServices.ViewModels
{
    public class HomePageTrendingSectionVM
    {
        public string Title { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
        public ICollection<HomePageTrendingSectionPartVM> Parts { get; set; }
        public string Image { get; set; }
    }
}
