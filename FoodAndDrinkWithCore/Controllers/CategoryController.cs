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
    _category.status = true; // Yeni eklenen kategori varsayılan olarak aktif olsun
    ModelState.Remove("status"); // Validasyondan bu alanı muaf tut
    ModelState.Remove("Foods");  // İlişkili listeyi validasyondan muaf tut

    if(!ModelState.IsValid)
    {
        return View("CategoryAdd");
    }
    categoryRepository.TAdd(_category);
    return RedirectToAction("Index");
}
		public IActionResult CategoryFind(int id)
		{
			var x = categoryRepository.TFind(id);
			Category category = new Category()
			{
				CategoryName=x.CategoryName,
				CategoryDesc=x.CategoryDesc,
				status=x.status,
				CategoryID=x.CategoryID
				
			};
			return View(category);
		}
		[HttpPost]
		public IActionResult CategoryUpdate(Category _category)
		{
			var x = categoryRepository.TFind(_category.CategoryID);
			x.CategoryName = _category.CategoryName;
			x.CategoryDesc = _category.CategoryDesc;
			x.status = true;
			categoryRepository.TUpdate(x);
			return RedirectToAction("Index");
		}
		public IActionResult CategoryRemove(int id)
		{
			var x = categoryRepository.TFind(id);
			x.status = false;//silme işlemini iliklili tablolarda statüyü false yaparak yapıyoruz
			categoryRepository.TUpdate(x);
			return RedirectToAction("Index");
		}
	}
}
