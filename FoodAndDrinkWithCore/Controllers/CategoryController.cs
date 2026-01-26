using FoodAndDrinkWithCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FoodAndDrinkWithCore.Controllers
{
	public class CategoryController : Controller
	{
		public IActionResult Index()
		{
			CategoryRepository categoryRepository = new CategoryRepository(); //öncelikle kullanacağımız repositoryden bir nesne türetiriz
			return View(categoryRepository.TList());//daha sonra genetic repodaki isteidğimiz metodu çağırabiliriz.
		}
	}
}
