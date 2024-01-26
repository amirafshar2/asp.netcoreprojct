





using BE.concrete;
using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager r = new WriterManager(new EfWriterRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer w)
		{
			w.About = "deneme test";
			w.Status = true;
			
			r.İnsert(w);
			return RedirectToAction("Index","Blog");
		}
	}
}
