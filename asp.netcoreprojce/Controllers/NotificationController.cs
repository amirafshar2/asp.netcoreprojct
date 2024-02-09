using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
    public class NotificationController : Controller
    {
        NotificationManager bll = new NotificationManager(new EfNotificationRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NotificationList()
        {
            var Value = bll.GetAll();
            return View(Value);
        }
    }
}
