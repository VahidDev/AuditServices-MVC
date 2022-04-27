using System.Collections.Generic;

namespace AuditServices.ViewModels
{
    public class FooterPartVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<FooterPartLinkVM> FooterPartLinks { get; set; }=
             new List<FooterPartLinkVM> { };
        public int Order { get; set; }
    }
}
