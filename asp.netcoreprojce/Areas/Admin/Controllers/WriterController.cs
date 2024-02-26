using BE.concrete;
using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        WriterManager _writerBLL = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            var Value = _writerBLL.GetAll();
            return View(Value);
        }
        [HttpPost]
        public IActionResult Readall()
        {
            return Json(_writerBLL.GetAll());
        }
        [HttpPost]
        public IActionResult ReadBayıd(int id)
        {
            var q = _writerBLL.GetAll().Where(i=>i.id==id).FirstOrDefault();
            return Json(q);
        }
        public IActionResult Creat(Writer w)
        {
            _writerBLL.İnsert(w);
            return Json(_writerBLL.GetAll());
        }

    }
}
