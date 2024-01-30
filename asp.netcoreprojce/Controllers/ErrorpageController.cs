using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
	public class ErrorpageController : Controller
	{
		public IActionResult Error1(int code)
		{
			return View();
		}
	}
}
