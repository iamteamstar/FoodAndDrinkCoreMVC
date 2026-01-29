using FoodAndDrinkWithCore.Data.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FoodAndDrinkWithCore.Controllers
{
	public class LoginController : Controller
	{
		Context c = new Context();
		[AllowAnonymous]
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[AllowAnonymous]
		[HttpPost]
		public async Task<IActionResult> Index(Admin _admin)
		{
			var girisBilgi = c.admins.FirstOrDefault(x => x.AdminUserName == _admin.AdminUserName && x.AdminPassword == _admin.AdminPassword);
			if( girisBilgi !=null)
			{
				var claim = new List<Claim>
				{
					new Claim(ClaimTypes.Name,_admin.AdminUserName)
				};

				var userIdentity = new ClaimsIdentity(claim, "Login");
				ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

				await HttpContext.SignInAsync(principal);
				return RedirectToAction("Index", "Category");
			}
			else
			{
				return View();
			}
		}
		public async Task<IActionResult> LogOut()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			return RedirectToAction("Index", "Login");
		}
			

	}
}
