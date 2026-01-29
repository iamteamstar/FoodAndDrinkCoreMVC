using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodAndDrinkWithCore.Controllers
{
	[AllowAnonymous]
	public class TemplateController : Controller
	{
		public IActionResult Index()//bu sayfa componentlerin görüneceği,asıl ana parça yani olmazsa olmaz 
			//componentleri kullanmak için ana iskelet
		{
			return View();
		}
		public IActionResult CategoryDetails(int id)
		{
			ViewBag.x = id;
			return View();
		}
	}
}
