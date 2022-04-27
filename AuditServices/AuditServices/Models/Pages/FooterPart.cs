using System.Collections.Generic;
using AuditServices.Models.Entities.Base;

namespace AuditServices.Models.Pages
{
    public class FooterPart:Entity
    {
        public string Title { get; set; }
        public ICollection<FooterPartLink> FooterPartLinks { get; set; }
        public int Order { get; set; }
        public Footer Footer { get; set; }
    }
}
