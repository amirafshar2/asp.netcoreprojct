using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.ViewComponents.Dashbaord
{
    public class DashboardCategoryList : ViewComponent
    {
        CategoryManager bll = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var q = bll.GetAll();
            return View(q);
        }

    }
}
