using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace AuditServices.Models.Entities
{
    public class User:IdentityUser
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime DeletedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Blog> Blogs { get; set; }
        public string Image { get; set; }
        public bool IsBlocked { get; set; }
    }
}
