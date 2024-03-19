using BE.concrete;
using BLL.Concreate;
using DAL.Context;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.ViewComponents.Dashbaord
{
    public class DashboardİmageCard : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        WriterManager bll = new WriterManager(new EfWriterRepository());
        DB db = new DB();

        public DashboardİmageCard(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {

            var UserMail = User.Identity.Name;
            ViewBag.veri = UserMail;
            var User1 = bll.GetWriterBayEmail(UserMail); ;
            var value = bll.GetWriterBayId(User1.id);
            return View(value);
        }
    }
}
