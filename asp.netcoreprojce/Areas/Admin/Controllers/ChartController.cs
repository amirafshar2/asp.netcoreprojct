using asp.netcoreprojce.Areas.Admin.Models;
using BLL.Concreate;
using DAL.Context;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace asp.netcoreprojce.Areas.Admin.Controllers
{
  
    public class ChartController : Controller
    {
        BlogeManager _BlogBll = new BlogeManager(new EfBlogRepository());
        CategoryManager _CategoryBll  = new CategoryManager(new EfCategoryRepository());
        [Area("Admin")]
        public IActionResult Index()
        {           
            
           
            return View();
        }
        //public void countt(List<CategoryChart> categoryCharts)
        //{
        //    List<CategoryChart> categoryChar = new List<CategoryChart>();
        //    countt(categoryChar);
        //    var Cat = _CategoryBll.GetAll();
        //    foreach (var item in Cat)
        //    {
        //        int coount = _BlogBll.GetBlogsFromCategory(item.id).Count();
        //        CategoryChart chart = new CategoryChart
        //        {
        //            Count = coount,
        //            Name = item.Name
        //        };
        //        categoryCharts.Add(chart);
        //    }
        //}
    }
}
