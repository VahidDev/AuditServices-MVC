using Microsoft.AspNetCore.Mvc;

namespace AuditServices.Controllers
{
    public class FinancesReportAuditController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
