using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace asp.netcoreprojce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WidgetsController : Controller
    {
        BlogeManager _blogbll = new BlogeManager(new EfBlogRepository());
        ContectManager _Contectbll = new ContectManager(new EfContactRepository());
        CommentManager _Commentbll = new CommentManager(new EFCommentRepository());
        public IActionResult Index()
        {
            ViewBag.BlogCount = _blogbll.GetAll().Count();
            ViewBag.Contectcount = _Contectbll.GetAll().Count();
            ViewBag.Commentcount = _Commentbll.GetAll().Count();
            return View();
        }
    }
}
