using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace asp.netcoreprojce.Areas.Admin.ViewComponents.Widgets
{
    public class Statistic3 : ViewComponent
    {
        AdminManager _Adminbll = new AdminManager(new EfAdminRepository());
        public IViewComponentResult Invoke()
        {
            
            var Value = _Adminbll.GetById(1);
            return View(Value);
        }
    }
}
