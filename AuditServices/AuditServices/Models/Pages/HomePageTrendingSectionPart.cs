using AuditServices.Models.Entities.Base;
namespace AuditServices.Models.Pages
{
    public class HomePageTrendingSectionPart:Entity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public HomePageTrendingSection TrendingSection { get; set; }
        public int Order { get; set; }
    }
}
