using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
    public class MessageController : Controller
    {
        MessageManager _bll = new MessageManager(new EfMessageRepository());
        public IActionResult Index()
        {
            var Value = _bll.GetListBayWriter(2);
            return View(Value);
        }
    }
}
