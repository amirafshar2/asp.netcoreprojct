using BE.concrete;
using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
	public class ContectController : Controller
	{
		ContectManager c = new ContectManager(new EfContactRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Contact cc)
		{
			cc.Date = DateTime.Now;
			cc.Status = true;
			c.Create(cc);
			return RedirectToAction("Index","Blog");
		}
	}
}
