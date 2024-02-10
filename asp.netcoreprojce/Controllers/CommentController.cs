using BE.concrete;
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
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment c)
        {
			c.Blogid = 2;
            c.Date = DateTime.Now;
			c.Status = true;
			
			cm.İnsert(c);
			
			return PartialView();
        }
        public PartialViewResult CommentListBayBlog()
		{
			return PartialView();
		}
	}
}
