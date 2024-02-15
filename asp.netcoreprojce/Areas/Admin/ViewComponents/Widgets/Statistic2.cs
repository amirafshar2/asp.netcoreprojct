using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Areas.Admin.ViewComponents.Widgets
{
    [Area("Admin")]
    public class Statistic2: ViewComponent
    {
        BlogeManager _blogbll = new BlogeManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            ViewBag.LastBlog = _blogbll.GetAll().OrderByDescending(i=>i.id).Select(x=>x.Title).Take(1).FirstOrDefault();
            return View();  
        }
    }
}
