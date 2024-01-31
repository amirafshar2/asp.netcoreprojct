using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
	[AllowAnonymous]
	public class AboutController : Controller
	{
		AboutManager bll = new AboutManager(new EFAbouteRepository());
		[AllowAnonymous]
		public IActionResult Index()
		{
			var value = bll.GetAll();
			return View(value);
		}
		[AllowAnonymous]
		public PartialViewResult SocialMedia()
		{
			return PartialView();
		}
	}
}
