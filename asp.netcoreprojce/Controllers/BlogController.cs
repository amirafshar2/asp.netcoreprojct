




using BE.concrete;
using BLL.Concreate;
using BLL.ValidationRules;
using DAL.EntityFrameWork;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace asp.netcoreprojce.Controllers
{
    public class BlogController : Controller
    {
        BlogeManager bl = new BlogeManager(new EfBlogRepository());
		[AllowAnonymous]
		public IActionResult Index()
        {
            var values = bl.GetBlogsFromCategory();
            return View(values);
        }
		[AllowAnonymous]
		public IActionResult BlogReadAll(int id)
        {
            ViewBag.Id = id;
            var value = bl.GetAll(id);
            return View(value);
        }
     
        public IActionResult BlogBayWriter () 
        {
            var value = bl.GetBlogByCategoryWithWriter(1);
            return View(value);
        }
        [HttpPost]
        public IActionResult ReadBlogBayWriter()
        {
            var value = bl.GetBlogByCategoryWithWriter(1);
            return Ok(value);

        }
       
        [HttpGet]
        public IActionResult BlogAdd()
        {
            CategoryManager c = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> CategoryValues = (from x in c.GetAll() select new SelectListItem{Text=x.Name , Value=x.id.ToString()}).ToList();
            ViewBag.cv = CategoryValues;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog b)
        {
           BlogValidator bv = new BlogValidator();
            ValidationResult result = bv.Validate(b);
            if (result.IsValid)
            {
                b.Status = true;
                b.CreateDate = DateTime.Now;
                b.Writerid = 1;

                bl.İnsert(b);
                return RedirectToAction("BlogBayWriter", "Blog");
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
       
        public ActionResult BlogRemove(int id)
        {
            var q= bl.GetById(id);
            bl.Delete(q);
            return RedirectToAction("BlogBayWriter");
        }
        [HttpGet]
        public ActionResult BlogUpdate(int id)
        {
            CategoryManager c = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> CategoryValues = (from x in c.GetAll() select new SelectListItem { Text = x.Name, Value = x.id.ToString() }).ToList();
            ViewBag.cv = CategoryValues;
            var q = bl.GetBayİd(id);
            return View(q);
        }
        [HttpPost]
        public ActionResult BlogUpdate(Blog b)
        {
            BlogValidator bv = new BlogValidator();
            ValidationResult result = bv.Validate(b);
            if (result.IsValid)
            {
                b.Status = true;
                b.CreateDate = DateTime.Now;
                b.Writerid = 1;

                bl.Update(b);
                return RedirectToAction("BlogBayWriter", "Blog");
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
