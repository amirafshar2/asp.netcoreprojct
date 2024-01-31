using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
	public class ErrorpageController : Controller
	{
		[AllowAnonymous]
		public IActionResult Error1(int code)
		{
			return View();
		}
	}
}
