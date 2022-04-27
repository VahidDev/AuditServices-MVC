using Microsoft.AspNetCore.Mvc;

namespace AuditServices.Controllers
{
    public class AccountingServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
