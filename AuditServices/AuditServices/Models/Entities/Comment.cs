using AuditServices.Models.Entities.Base;

namespace AuditServices.Models.Entities
{
    public class Comment:Entity
    {
        public User User { get; set; }
        public Blog Blog { get; set; }
        public string Text { get; set; }
    }
}
