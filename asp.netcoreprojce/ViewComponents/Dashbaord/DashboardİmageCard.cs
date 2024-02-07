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
            var value = bll.GetWriterBayId(1);
            return View(value);
        }
    }
}
