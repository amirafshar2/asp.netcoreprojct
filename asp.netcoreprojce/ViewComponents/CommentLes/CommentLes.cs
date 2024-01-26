using BLL.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.ViewComponents.CommentLes
{
    public class CommentLes : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
