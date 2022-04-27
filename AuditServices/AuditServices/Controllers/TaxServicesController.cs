using Microsoft.AspNetCore.Mvc;

namespace AuditServices.Controllers
{
    public class TaxServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
