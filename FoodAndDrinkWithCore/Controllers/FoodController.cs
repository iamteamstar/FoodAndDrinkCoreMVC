using FoodAndDrinkWithCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FoodAndDrinkWithCore.Controllers
{
	public class FoodController : Controller
	{
		public IActionResult Index()
		{
			FoodRepository foodRepository = new FoodRepository();
			return View(foodRepository.TList("Category"));//category sınıfından bir değer alacağımız için(name) parametre olarak onu yazdık
		}
	}
}
