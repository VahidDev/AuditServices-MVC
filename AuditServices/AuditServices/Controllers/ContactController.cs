using Microsoft.AspNetCore.Mvc;

namespace AuditServices.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
