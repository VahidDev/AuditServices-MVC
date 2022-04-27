using System.Collections.Generic;
using AuditServices.Models.Entities;

namespace AuditServices.ViewModels.AccountVMs
{
    public class AccountIndexVM
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
