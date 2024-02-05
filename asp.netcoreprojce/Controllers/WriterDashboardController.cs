using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
    public class WriterDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
