using BE.concrete;
using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.ViewComponents.Writer
{
    public class WriterDashboardCarts : ViewComponent
    {

        BlogeManager _Blogbll = new BlogeManager(new EfBlogRepository());
        CategoryManager _categorybll = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
            ViewBag.bl= _Blogbll.GetAll().Count().ToString();
            ViewBag.wbl=_Blogbll.GetBlogByCategoryWithWriter(2).Count().ToString();
            ViewBag.cl = _categorybll.GetAll().Count().ToString();
            return View();
        }
    }
}
