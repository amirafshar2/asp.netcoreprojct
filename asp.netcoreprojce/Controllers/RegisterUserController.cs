using BE.concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcoreprojce.Controllers
{
    [AllowAnonymous]
    public class RegisterUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterUserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Models.LoginSignupModelUser U)
        {
            //if (ModelState.IsValid)
            //{
                AppUser user = new AppUser()
                {
                    Email = U.Email,
                    UserName = U.UserName,
                    Name_SureName = U.Name_SureName
                };
                var result = await _userManager.CreateAsync(user, U.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            //}
            return View();
        }
    }
}
