using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace AuditServices.ViewModels.AccountVMs
{
    public class AccountRegisterVM
    {
        [Required(ErrorMessage = "Istifadəçi adi daxil etməlisiniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifre daxil olunmalıdir"), DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifrə təkrarən daxil olunmalıdir"), DataType(DataType.Password),
        Compare(nameof(Password), ErrorMessage = "Şifreler uyğun deyil")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Email daxil etməlisiniz"),
         DataType(DataType.EmailAddress, ErrorMessage = "Düzgun email daxil edin!")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Profil şəkli yükləməlisiniz")]
        public IFormFile Image { get; set; }
        public string Message { get; set; }
    }
}
