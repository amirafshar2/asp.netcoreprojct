using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.ViewComponents.Dashbaord
{
    public class DashboardİmageCard : ViewComponent
    {
        BlogeManager bll = new BlogeManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var value = bll.GetLast3Blogs();
            return View(value);
        }
    }
}
