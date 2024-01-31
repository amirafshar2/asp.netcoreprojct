using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
		[AllowAnonymous]
		public IActionResult Index()
        {
            var values = cm.GetAll();

            return View(values);
        }
    }
}
