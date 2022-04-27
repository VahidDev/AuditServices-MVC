using Microsoft.AspNetCore.Mvc;

namespace AuditServices.Controllers
{
    public class OutsourceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
