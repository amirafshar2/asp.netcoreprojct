using BLL.Concreate;
using DAL.EntityFrameWork;
using DAL.Repostory;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EFCommentRepository());
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
