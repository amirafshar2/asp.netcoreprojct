using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.ViewComponents.Dashbaord
{
    public class WriterDashboardLast10BlogList : ViewComponent
    {
        BlogeManager bll = new BlogeManager(new EfBlogRepository());
        public IViewComponentResult Invoke() 
        {
            var value = bll.Last10BlogList();
            return View(value);
        }


    }
}
