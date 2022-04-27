using Microsoft.AspNetCore.Mvc;

namespace AuditServices.Controllers
{
    public class TaxAuditServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
