using System.Collections.Generic;
using AuditServices.Models.Entities;

namespace AuditServices.ViewModels.AdminVMs.UserVMs
{
    public class UserDetailVM
    {
        public ICollection<Blog> Blogs{ get; set; }
        public User User { get; set; }
    }
}
