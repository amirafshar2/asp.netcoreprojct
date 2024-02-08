using BE.concrete;
using BLL.Concreate;
using BLL.ValidationRules;
using DAL.EntityFrameWork;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace asp.netcoreprojce.Controllers
{
    public class WriterController : Controller
    {

        WriterManager bll = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult WriterSideBar()
        {
            return PartialView();
        }
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var value = bll.GetById(1);
            return View(value);
        }
        [HttpPost]
        public IActionResult WriterEditProfile(Writer w)
        {
            WriterValidator vl = new WriterValidator();
            ValidationResult result = vl.Validate(w);
            if (result.IsValid)
            {
                w.İmage = "/CoreTema/images/11.jpg";
                bll.Updatew(1,w);
                return RedirectToAction("Index", "WriterDashboard");
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
