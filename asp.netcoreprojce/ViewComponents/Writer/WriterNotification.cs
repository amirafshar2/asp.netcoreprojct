using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
