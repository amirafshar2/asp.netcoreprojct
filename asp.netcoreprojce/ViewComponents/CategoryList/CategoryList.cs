using BLL.Concreate;
using DAL.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.ViewComponents.CategoryList
{
	public class CategoryList : ViewComponent
	{
		CategoryManager _categorymanager = new CategoryManager (new EfCategoryRepository());
		public IViewComponentResult Invoke()
		{
			var value = _categorymanager.GetAll();

			return View(value);
		}
	}
}
