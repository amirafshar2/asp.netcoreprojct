using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace asp.netcoreprojce.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        NotificationManager bll = new NotificationManager(new EfNotificationRepository());
        public IViewComponentResult Invoke()
        {
            var value = bll.GetAllTrue();
            return View(value);
        }
    }
}
