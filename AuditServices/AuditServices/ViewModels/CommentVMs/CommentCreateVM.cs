using System.ComponentModel.DataAnnotations;
using AuditServices.Constants.MessageConstants;

namespace AuditServices.ViewModels.CommentVMs
{
    public class CommentCreateVM
    {
        [Required(ErrorMessage = CommonErrorMessageConstants.EmptyFieldErrorMessage)]
        public string Text { get; set; }
    }
}
