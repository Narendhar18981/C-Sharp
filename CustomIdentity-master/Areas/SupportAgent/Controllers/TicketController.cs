using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Customer_Support_Management_System.Areas.SupportAgent.Controllers
{
    [Area("SupportAgent")]
    [Authorize(Roles = "SupportAgent")]
    public class TicketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UpdateStatus(int id, string status)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
