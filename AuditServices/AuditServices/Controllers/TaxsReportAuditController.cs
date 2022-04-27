using Microsoft.AspNetCore.Mvc;

namespace AuditServices.Controllers
{
    public class TaxsReportAuditController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
