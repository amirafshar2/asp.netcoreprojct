using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
