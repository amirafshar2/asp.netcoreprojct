using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.ViewComponents.Blog
{
	public class WriterLastBlog : ViewComponent
	{
		BlogeManager _blogManager = new BlogeManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
		{
			var values = _blogManager.GetBlogByWriter(1);
			return View(values);	
		}
    }
}
