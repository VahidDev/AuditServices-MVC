using System.ComponentModel.DataAnnotations;
using AuditServices.Constants.MessageConstants;

namespace AuditServices.ViewModels.AdminVMs.PageVMs.FooterVMs
{
    public class FooterPartLinkUpdateVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = CommonErrorMessageConstants.EmptyFieldErrorMessage)]
        public string Text { get; set; }
        [Required(ErrorMessage = CommonErrorMessageConstants.EmptyFieldErrorMessage)]
        public string Link { get; set; }
    }
}
