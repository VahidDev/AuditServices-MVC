using System.Collections.Generic;
using AuditServices.Models.Entities.Base;

namespace AuditServices.Models.Pages
{
    public class HomePageTrendingSection:Entity
    {
        public string Title { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
        public ICollection<HomePageTrendingSectionPart> Parts { get; set; }
        public string Image { get; set; }
    }
}
