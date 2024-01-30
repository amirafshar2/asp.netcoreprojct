using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.ViewComponents.Blog
{


    public class ListAllBlog : ViewComponent
    {
        BlogeManager bll = new BlogeManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = bll.GetAll();
            return View(values);
        }
    }
}