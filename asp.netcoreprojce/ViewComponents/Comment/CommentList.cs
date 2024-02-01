using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.ViewComponents.Comment
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
