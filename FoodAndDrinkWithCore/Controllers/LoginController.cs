using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodAndDrinkWithCore.Controllers
{
	public class LoginController : Controller
	{
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}

	}
}
