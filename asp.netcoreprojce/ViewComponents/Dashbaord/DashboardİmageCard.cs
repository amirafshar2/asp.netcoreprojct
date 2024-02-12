using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.ViewComponents.Dashbaord
{
    public class DashboardİmageCard : ViewComponent
    {
        WriterManager bll = new WriterManager(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
            var UserMail = User.Identity.Name;
            var User1 = bll.GetWriterBayEmail(UserMail); ;
            var value = bll.GetWriterBayId(User1.id);
            return View(value);
        }
    }
}
