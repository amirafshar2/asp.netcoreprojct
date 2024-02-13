using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace asp.netcoreprojce.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager _bll = new CategoryManager(new EfCategoryRepository());
        [Area("Admin")]
        public IActionResult Index(int page = 10)
        {
            var Value = _bll.GetAll().ToPagedList(page,1);
            return View(Value);
        }

    }
}
