using System.ComponentModel.DataAnnotations;
using AuditServices.Constants.MessageConstants;
using Microsoft.AspNetCore.Http;

namespace AuditServices.ViewModels.AdminVMs.PageVMs.HomePageVMs
{
    public class HomePageTrendingSectionUpdateVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage =CommonErrorMessageConstants.EmptyFieldErrorMessage)]
        public string Title { get; set; }
        [Required(ErrorMessage = CommonErrorMessageConstants.EmptyFieldErrorMessage)]
        public string Tag { get; set; }
        [Required(ErrorMessage = CommonErrorMessageConstants.EmptyFieldErrorMessage)]
        public string Description { get; set; }
        public IFormFile NewImage { get; set; }
    }
}
