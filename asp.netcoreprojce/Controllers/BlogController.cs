using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
