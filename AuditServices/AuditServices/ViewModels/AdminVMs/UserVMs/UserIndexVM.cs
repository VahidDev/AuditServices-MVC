using System.Collections.Generic;
using AuditServices.Utilities.UserUtilities;

namespace AuditServices.ViewModels.AdminVMs.UserVMs
{
    public class UserIndexVM
    {
        public ICollection<UserAndRole> UsersRoles { get; set; } = new List<UserAndRole>();
    }
}
