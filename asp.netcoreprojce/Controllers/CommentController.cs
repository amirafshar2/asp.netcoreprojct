using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
	public class CommentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		public PartialViewResult CommentListBayBlog()
		{
			return PartialView();
		}
	}
}
