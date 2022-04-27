using System.ComponentModel.DataAnnotations;
using AuditServices.Constants.MessageConstants;
using Microsoft.AspNetCore.Http;

namespace AuditServices.ViewModels.BlogVMs
{
    public class BlogCreateVM
    {
        [Required(ErrorMessage = FileMessageConstants.NoFileError)]
        public IFormFile Image { get; set; }
        [Required(ErrorMessage ="Bu sahə doldurulmalıdır!")]
        public string Description { get; set; }
    }
}
