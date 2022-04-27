using System.Collections.Generic;
using AuditServices.Models.Entities;

namespace AuditServices.Utilities.UserUtilities
{
    public class UserAndRole
    {
        public User User { get; set; }
        public ICollection<string> RolesNames { get; set; }
    }
}
