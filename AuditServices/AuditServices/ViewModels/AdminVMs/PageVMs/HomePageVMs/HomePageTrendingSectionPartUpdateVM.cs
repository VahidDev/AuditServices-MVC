using System.ComponentModel.DataAnnotations;
using AuditServices.Constants.MessageConstants;

namespace AuditServices.ViewModels.AdminVMs.PageVMs.HomePageVMs
{
    public class HomePageTrendingSectionPartUpdateVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = CommonErrorMessageConstants.EmptyFieldErrorMessage)]
        public string Title { get; set; }
        [Required(ErrorMessage = CommonErrorMessageConstants.EmptyFieldErrorMessage)]
        public string Content { get; set; }
        [Required(ErrorMessage = CommonErrorMessageConstants.EmptyFieldErrorMessage)]
        public int Order { get; set; }
    }
}
