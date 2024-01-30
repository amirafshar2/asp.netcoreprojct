using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
	public class AboutController : Controller
	{
		AboutManager bll = new AboutManager(new EFAbouteRepository());
		public IActionResult Index()
		{
			var value = bll.GetAll();
			return View(value);
		}
		public PartialViewResult SocialMedia()
		{
			return PartialView();
		}
	}
}
