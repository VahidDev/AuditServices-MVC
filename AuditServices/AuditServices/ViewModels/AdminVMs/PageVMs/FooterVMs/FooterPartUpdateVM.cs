using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AuditServices.Constants.MessageConstants;

namespace AuditServices.ViewModels.AdminVMs.PageVMs.FooterVMs
{
    public class FooterPartUpdateVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage =CommonErrorMessageConstants.EmptyFieldErrorMessage)]
        public string Title { get; set; }
        public IList<FooterPartLinkUpdateVM> FooterPartLinks { get; set; }
        [Required(ErrorMessage = CommonErrorMessageConstants.EmptyFieldErrorMessage)]
        public int Order { get; set; }
    }
}
