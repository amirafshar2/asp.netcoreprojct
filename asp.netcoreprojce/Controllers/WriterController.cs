using BE.concrete;
using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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

            return View();
        }
    }
}
