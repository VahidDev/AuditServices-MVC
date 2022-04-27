using System.Collections.Generic;
using AuditServices.Models.Entities;

namespace AuditServices.ViewModels.BlogVMs
{
    public class BlogIndexVM
    {
        public ICollection<Blog> Blogs { get; set; }
        public BlogCreateVM BlogCreateVM { get; set; }
    }
}
