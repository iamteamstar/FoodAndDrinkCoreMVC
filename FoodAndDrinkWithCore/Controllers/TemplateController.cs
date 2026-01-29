using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodAndDrinkWithCore.Controllers
{
	[AllowAnonymous]
	public class TemplateController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
