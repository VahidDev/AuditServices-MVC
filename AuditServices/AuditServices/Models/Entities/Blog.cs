using System.Collections.Generic;
using AuditServices.Models.Entities.Base;

namespace AuditServices.Models.Entities
{
    public class Blog:Entity
    {
        public string Image { get; set; }
        public User User { get; set; }
        public string Description { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public int CommentsCount { get; set; }
    }
}
