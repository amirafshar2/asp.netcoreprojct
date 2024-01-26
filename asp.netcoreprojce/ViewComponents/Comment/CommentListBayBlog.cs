using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.ViewComponents.Comment
{
	public class CommentListBayBlog : ViewComponent
	{

		CommentManager _commentManager = new CommentManager(new EFCommentRepository());

		

		public IViewComponentResult Invoke(int id)
		{

			var value = _commentManager.GetAll(id);
            if (value == null || !value.Any())
            {
                return View("~/Views/Shared/Components/CommentLes/Default.cshtml");
			}
			else
			{
                return View(value);
            }

           
		}
	}
}
