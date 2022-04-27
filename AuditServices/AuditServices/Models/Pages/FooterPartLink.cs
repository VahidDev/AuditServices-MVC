using AuditServices.Models.Entities.Base;

namespace AuditServices.Models.Pages
{
    public class FooterPartLink:Entity
    {
        public string Text { get; set; }
        public string Link { get; set; }
        public FooterPart FooterPart { get; set; }
    }
}
