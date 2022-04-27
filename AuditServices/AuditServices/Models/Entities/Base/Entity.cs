using System;

namespace AuditServices.Models.Entities.Base
{
    public class Entity:IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime DeletedDate { get; set; }
    }
}
