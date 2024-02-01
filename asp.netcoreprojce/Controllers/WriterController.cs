using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
    public class WriterController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult WriterSideBar()
        {
            return PartialView();
        }
    }
}
