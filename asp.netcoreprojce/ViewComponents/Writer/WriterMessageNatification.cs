using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.ViewComponents.Writer
{
    public class WriterMessageNatification :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
