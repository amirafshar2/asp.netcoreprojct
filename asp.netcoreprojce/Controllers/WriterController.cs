using BE.concrete;
using BLL.Concreate;
using BLL.ValidationRules;
using DAL.EntityFrameWork;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace asp.netcoreprojce.Controllers
{
    public class WriterController : Controller
    {

        WriterManager bll = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            var UserMail = User.Identity.Name;
            ViewBag.v=UserMail;
            return View();
        }
        public PartialViewResult WriterSideBar()
        {
            return PartialView();
        }

        



        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var UserEmail = User.Identity.Name;
            var U = bll.GetWriterBayEmail(UserEmail);
            var value = bll.GetById(U.id);
            return View(value);
        }
        [HttpPost]
        public IActionResult WriterEditProfile(Writer w)
        {
            var UserEmail = User.Identity.Name;
            var U = bll.GetWriterBayEmail(UserEmail);
            WriterValidator vl = new WriterValidator();
            ValidationResult result = vl.Validate(w);
            if (result.IsValid)
            {
                w.İmage = "/CoreTema/images/11.jpg";
                bll.Updatew(U.id,w);
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




        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult WriterAdd(Models.Writer w)
        {
            Writer wr = new Writer();
            if (w.İmage!= null)
            {
                var extention = Path.GetExtension(w.İmage.FileName);
                var newimagename = Guid.NewGuid() + extention;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterİmageFile/", newimagename);
                var stream = new FileStream(location,FileMode.Create);
                w.İmage.CopyTo(stream);
                wr.İmage = newimagename;
            }
            wr.Mail = w.Mail;
            wr.Name = w.Mail;
            wr.About = w.About;
            wr.Status = w.Status;
            wr.Password = w.Password;
            bll.İnsert(wr);
            return RedirectToAction("Index", "WriterDashboard");
        }
    }
}
