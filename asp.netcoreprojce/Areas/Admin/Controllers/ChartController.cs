using asp.netcoreprojce.Areas.Admin.Models;
using BE.concrete;
using BLL.Concreate;
using DAL.EntityFrameWork;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace asp.netcoreprojce.Areas.Admin.Controllers
{
    public class ChartController : Controller
    {
        BlogeManager _BlogBLL = new BlogeManager(new EfBlogRepository());
        CategoryManager _CategoryBLL = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            List<CategoryChart> CategoryChart = new List<CategoryChart>();
            var categories = _CategoryBLL.GetAll();
            foreach (var category in categories)
            {
                int blogCount = _BlogBLL.GetBlogsFromCategory().Count(b => b.Categoryid == category.id);
                CategoryChart.Add(new CategoryChart { Count = blogCount, CategoryName = category.Name });
            }
            return View(CategoryChart);
        }


    }



}





