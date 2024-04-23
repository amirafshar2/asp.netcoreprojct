using BE.concrete;
using DAL.Context;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace asp.netcoreprojce.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Models.UserSignİnView u)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(u.username, u.password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "WriterDashboard");
                }
                else
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            return View();
        }




        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> Index(Writer p)
        //{
        //    DB db = new DB();
        //    var d = db.writers.Where(i => i.Mail == p.Mail && i.Password == p.Password).FirstOrDefault();
        //    if (d != null)
        //    {
        //        var Claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name,p.Mail)
        //        };
        //        var UserIdentitiy = new ClaimsIdentity(Claims, "a");
        //        ClaimsPrincipal principal = new ClaimsPrincipal(UserIdentitiy);
        //        await HttpContext.SignInAsync(principal);
        //        return RedirectToAction("Index", "WriterDashboard");
        //    }
        //    else
        //    {
        //        return View();
        //    }





        //}
    }
}
//         DB db = new DB();
//         var d = db.writers.Where(i => i.Mail == p.Mail && i.Password == p.Password).FirstOrDefault();
//         if (d != null)
//         {
//             HttpContext.Session.SetString("UserName", p.Mail);
//             return RedirectToAction("Index", "Writer");
//         }
//         else
//         {
//	return View();
//}