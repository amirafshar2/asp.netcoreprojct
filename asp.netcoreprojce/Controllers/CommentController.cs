using BE.concrete;
using BLL.Concreate;
using DAL.EntityFrameWork;
using DAL.Repostory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EFCommentRepository());
        [AllowAnonymous]
        public IActionResult Index()
		{
			return View();
		}
        [AllowAnonymous]
        [HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
        [AllowAnonymous]
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment c)
        {
			c.Blogid = 2;
            c.Date = DateTime.Now;
			c.Status = true;
			
			cm.İnsert(c);
			
			return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult CommentListBayBlog()
		{
			return PartialView();
		}
	}
}
