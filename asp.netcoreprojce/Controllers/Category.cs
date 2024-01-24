using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
    public class Category : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = cm.GetAll();
            return View(values);
        }
    }
}
