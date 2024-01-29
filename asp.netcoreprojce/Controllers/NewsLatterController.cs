using BE.concrete;
using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
	public class NewsLatterController : Controller
	{
		NewsLatterManager nl = new NewsLatterManager(new EfNewsLatterRepository());
		[HttpGet]
		public PartialViewResult Index()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult Index(NewsLatter n)
		{
			n.Status = true;
			nl.AddNewsLatter(n);
			return PartialView();
		}
	}
}
