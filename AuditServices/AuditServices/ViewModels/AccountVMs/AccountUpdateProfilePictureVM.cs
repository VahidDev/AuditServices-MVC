using System.ComponentModel.DataAnnotations;
using AuditServices.Constants.MessageConstants;
using Microsoft.AspNetCore.Http;

namespace AuditServices.ViewModels.AccountVMs
{
    public class AccountUpdateProfilePictureVM
    {
        public string CurrentImage { get; set; }
        [Required(ErrorMessage =CommonErrorMessageConstants.EmptyFieldErrorMessage)]
        public IFormFile NewImage { get; set; }
    }
}
