using BLL.Concreate;
using Microsoft.AspNetCore.Mvc;
using DAL.EntityFrameWork;

namespace asp.netcoreprojce.ViewComponents.Writer
{
    public class WriterMessageNatification :ViewComponent
    {
        MessageManager _bll = new MessageManager(new EfMessageRepository());
        public IViewComponentResult Invoke()
        {
            var value = _bll.GetListBayWriter(2);
            return View(value);
        }
    }
}
