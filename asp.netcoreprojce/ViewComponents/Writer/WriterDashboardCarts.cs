using BE.concrete;
using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.ViewComponents.Writer
{
    public class WriterDashboardCarts : ViewComponent
    {

      
        public IViewComponentResult Invoke()
        {
           
            return View();
        }
    }
}
