using Microsoft.AspNetCore.Mvc;

namespace AuditServices.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
