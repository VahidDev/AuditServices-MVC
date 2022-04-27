using Microsoft.AspNetCore.Mvc;

namespace AuditServices.Controllers
{
    public class AuditServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
