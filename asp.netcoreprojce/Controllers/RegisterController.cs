





using BE.concrete;
using BLL.Concreate;
using BLL.ValidationRules;
using DAL.EntityFrameWork;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;


namespace asp.netcoreprojce.Controllers
{
	[AllowAnonymous]
	public class RegisterController : Controller
	{
		
		WriterManager r = new WriterManager(new EfWriterRepository());
		
		[HttpGet]
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		[AllowAnonymous]
		public IActionResult Index(Writer w)
		{
			WriterValidator vw = new WriterValidator();
			ValidationResult result = vw.Validate(w);
			if (result.IsValid)
			{
				r.İnsert(w);
				return RedirectToAction("Index", "Blog");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
				}
			}
			return View();
		}
	}
}
