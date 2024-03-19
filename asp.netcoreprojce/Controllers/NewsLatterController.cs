using BE.concrete;
using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
	public class NewsLatterController : Controller
	{
		NewsLatterManager nl = new NewsLatterManager(new EfNewsLatterRepository());
		[HttpGet]
		[AllowAnonymous]
		public PartialViewResult Index()
		{
			return PartialView();
		}

        [AllowAnonymous]
        [HttpPost]
		public PartialViewResult Index(NewsLatter n)
		{
			n.Status = true;
			nl.İnsert(n);
			return PartialView();
		}
	}
}
