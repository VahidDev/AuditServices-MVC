using System.Collections.Generic;
using AuditServices.Models.Entities.Base;
namespace AuditServices.Models.Pages
{
    public class Footer:Entity
    {
        public string YoutubeLink { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        public string LinkedInLink { get; set; }
        public string Content { get; set; }
        public ICollection<FooterPart> FooterParts { get; set; }
    }
}
