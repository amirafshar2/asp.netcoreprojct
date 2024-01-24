using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
    public class BlogController : Controller
    {
        BlogeManager bl = new BlogeManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bl.GetAll();
            return View(values);
        }
    }
}
