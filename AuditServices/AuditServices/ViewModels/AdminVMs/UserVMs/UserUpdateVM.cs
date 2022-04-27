using System.ComponentModel.DataAnnotations;
using AuditServices.Constants.MessageConstants;
using Microsoft.AspNetCore.Http;

namespace AuditServices.ViewModels.AdminVMs.UserVMs
{
    public class UserUpdateVM
    {
        public string Id { get; set; }
        [Required(ErrorMessage ="User name daxil olunmalidir!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email daxil olunmalidir!"),
            DataType(DataType.EmailAddress,ErrorMessage ="Email duzgun formatda deyil!")]
        public string Email { get; set; }
        public IFormFile Image { get; set; }
    }
}
