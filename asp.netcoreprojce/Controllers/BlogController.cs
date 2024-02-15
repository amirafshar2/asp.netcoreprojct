




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
        WriterManager _wbll = new WriterManager(new EfWriterRepository());

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
            var UserEmail = User.Identity.Name;
            var U = _wbll.GetWriterBayEmail(UserEmail);
            var value = bl.GetBlogByCategoryWithWriter(U.id);
            return View(value);
        }
        public IActionResult ReadBlogBayWriter()
        {
            var UserEmail = User.Identity.Name;
            var U = _wbll.GetWriterBayEmail(UserEmail);
            var value = bl.GetBlogByCategoryWithWriter(U.id);
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
                var UserEmail = User.Identity.Name;
                var U = _wbll.GetWriterBayEmail(UserEmail);
                b.Status = true;
                b.CreateDate = DateTime.Now;
                b.Writerid = U.id;

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
                var UserEmail = User.Identity.Name;
                var U = _wbll.GetWriterBayEmail(UserEmail);
                b.Status = true;
                b.CreateDate = DateTime.Now;
                b.Writerid = U.id;

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
