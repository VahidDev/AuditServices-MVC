using Microsoft.AspNetCore.Mvc;

namespace AuditServices.Controllers
{
    public class TaxAdviceServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
