




using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
    public class BlogController : Controller
    {
        BlogeManager bl = new BlogeManager(new EfBlogRepository());
		[AllowAnonymous]
		public IActionResult Index()
        {
            var values = bl.GetBlogsFromCategory();
            return View(values);
        }
		[AllowAnonymous]
		public IActionResult BlogReadAll(int id)
        {
            ViewBag.Id = id;
            var value = bl.GetAll(id);
            return View(value);
        }

	}
}
