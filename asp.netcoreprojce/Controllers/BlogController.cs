




using BE.concrete;
using BLL.Concreate;
using BLL.ValidationRules;
using DAL.EntityFrameWork;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
            var value = bl.GetBlogByWriter(1);
            return View(value);
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog b)
        {
            WriterValidator bv = new WriterValidator();
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
    }
}
