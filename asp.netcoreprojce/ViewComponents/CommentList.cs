using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
