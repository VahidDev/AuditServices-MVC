using System.Collections.Generic;

namespace AuditServices.ViewModels
{
    public class FooterVM
    {
        public string YoutubeLink { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        public string LinkedInLink { get; set; }
        public string Content { get; set; }
        public ICollection<FooterPartVM> FooterParts { get; set; } =
            new List<FooterPartVM> { };
    }
}
