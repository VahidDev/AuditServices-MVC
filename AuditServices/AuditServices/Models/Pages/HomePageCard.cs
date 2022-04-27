using AuditServices.Models.Entities.Base;

namespace AuditServices.Models.Pages
{
    public class HomePageCard:Entity
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
        public int Order { get; set; }
    }
}
