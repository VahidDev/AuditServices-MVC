using Microsoft.AspNetCore.Mvc;
namespace AuditServices.Controllers
{
    public class AboutController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
