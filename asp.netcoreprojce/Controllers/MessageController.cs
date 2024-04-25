using BE.concrete;
using BLL.Concreate;
using DAL.Context;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
    public class MessageController : Controller
    {
        MessageManager _bll = new MessageManager(new EfMessageRepository());
        DB db = new DB();
        public IActionResult Index()
        {
            var username = User.Identity.Name;
            var usermail = db.Users.Where(x => x.UserName == username).Select(t => t.Email).FirstOrDefault();
            var writerid = db.writers.Where(r => r.Mail == usermail).Select(y => y.id).FirstOrDefault();
            var Value = _bll.GetListBayWriter(writerid);
            return View(Value);
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMessage(Message2 m)
        {
            return View();
        }
    }
}
