




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
            var values = bl.GetBlogsFromCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            var value = bl.GetAll(id);
            return View(value);
        }

	}
}
