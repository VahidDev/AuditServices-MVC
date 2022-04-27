using System.ComponentModel.DataAnnotations;

namespace AuditServices.ViewModels.AccountVMs
{
    public class AccountLoginVM
    {
        [Required(ErrorMessage = "Istifadəşi adi daxil etməlisiniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifre daxil olunmalıdir"), DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
