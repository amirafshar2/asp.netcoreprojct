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
            
            var Name = User.Identity.Name;
            ViewBag.veri = Name;
            var UserMail = db.Users.Where(i => i.UserName == Name).Select(t => t.Email).FirstOrDefault();
            var User1 = db.Users.Where(x => x.UserName == Name).ToList();
            //var value = bll.GetWriterBayId(User1.id);
            return View(User1);
        }
    }
}
