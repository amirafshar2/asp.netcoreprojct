using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
