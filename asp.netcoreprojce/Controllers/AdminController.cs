using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
    public class AdminController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
