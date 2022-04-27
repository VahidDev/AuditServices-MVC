using Microsoft.AspNetCore.Mvc;

namespace AuditServices.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
