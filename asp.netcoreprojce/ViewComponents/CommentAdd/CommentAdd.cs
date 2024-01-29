





using BE.concrete;
using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;


namespace asp.netcoreprojce.ViewComponents.CommentAdd
{
	
	
	
	public class CommentAdd :ViewComponent
	{
		
		CommentManager c = new CommentManager(new EFCommentRepository());
		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
