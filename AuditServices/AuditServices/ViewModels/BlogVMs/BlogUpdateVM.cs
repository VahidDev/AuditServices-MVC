using System.ComponentModel.DataAnnotations;
using AuditServices.Constants.MessageConstants;
using Microsoft.AspNetCore.Http;

namespace AuditServices.ViewModels.BlogVMs
{
    public class BlogUpdateVM
    {
        public string CurrentImage { get; set; }
        [Required(ErrorMessage =CommonErrorMessageConstants.EmptyFieldErrorMessage)]
        public string Description { get; set; }
        public IFormFile NewImage { get; set; }
        public int BlogId { get; set; }

    }
}
