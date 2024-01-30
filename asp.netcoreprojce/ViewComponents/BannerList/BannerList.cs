using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.ViewComponents.BannerList
{



	public class BannerList : ViewComponent
	{
		BlogeManager bll = new BlogeManager(new EfBlogRepository());
		public IViewComponentResult Invoke()
		{
			var value = bll.GetAll(); 
			return View(value);
		}
		
	}
}
