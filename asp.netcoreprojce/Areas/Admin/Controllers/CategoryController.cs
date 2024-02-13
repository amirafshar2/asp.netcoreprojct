


using BE.concrete;
using BLL.Concreate;
using BLL.ValidationRules;
using DAL.EntityFrameWork;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

using X.PagedList;

namespace asp.netcoreprojce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager _bll = new CategoryManager(new EfCategoryRepository());
       
        public IActionResult Index(int page = 1)
        {
            var Value = _bll.GetAll().ToPagedList(page,10);
            return View(Value);
        }
        
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category c)
        {
            CategoryValidaiton cv = new CategoryValidaiton();
            ValidationResult result = cv.Validate(c);
            if (result.IsValid)
            {
                c.Status = true;
                _bll.İnsert(c);
                return RedirectToAction("Index", "Category");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
