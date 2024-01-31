using BE.concrete;
using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
	public class ContectController : Controller
	{
		ContectManager c = new ContectManager(new EfContactRepository());
		[HttpGet]
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		[AllowAnonymous]
		public IActionResult Index(Contact cc)
		{
			cc.Date = DateTime.Now;
			cc.Status = true;
			c.Create(cc);
			return RedirectToAction("Index","Blog");
		}
	}
}
