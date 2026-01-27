using FoodAndDrinkWithCore.Data.Models;
using FoodAndDrinkWithCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using FoodAndDrinkWithCore.Data.Models;

namespace FoodAndDrinkWithCore.Controllers
{
	public class CategoryController : Controller
	{
		CategoryRepository categoryRepository = new CategoryRepository(); //öncelikle kullanacağımız repositoryden bir nesne türetiriz

		public IActionResult Index()
		{
			return View(categoryRepository.TList());//daha sonra genetic repodaki isteidğimiz metodu çağırabiliriz.
		}

		[HttpGet]
		public IActionResult CategoryAdd()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CategoryAdd(Category _category)
		{
			categoryRepository.TAdd(_category);//generic repo kullanıdğımız için saveChanges yapmamıza gerek yok.
			return RedirectToAction("Index");
		}
	}
}
