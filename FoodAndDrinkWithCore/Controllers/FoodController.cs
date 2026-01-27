using FoodAndDrinkWithCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using FoodAndDrinkWithCore.Data.Models;

namespace FoodAndDrinkWithCore.Controllers
{
	public class FoodController : Controller
	{
		FoodRepository foodRepository = new FoodRepository();

		public IActionResult Index()
		{
			return View(foodRepository.TList("Category"));//category sınıfından bir değer alacağımız için(name) parametre olarak onu yazdık
		}
		[HttpGet]	
		public IActionResult FoodAdd()
		{
			return View();
		}
		[HttpPost]
		public IActionResult FoodAdd(Food _food)
		{
			foodRepository.TAdd(_food);
			return RedirectToAction("Index");
		}
	}
}
