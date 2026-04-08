using FoodAndDrinkWithCore.Data.Models;
using FoodAndDrinkWithCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using FoodAndDrinkWithCore.Data.Models;

namespace FoodAndDrinkWithCore.Controllers
{
	public class CategoryController : Controller
	{
		CategoryRepository categoryRepository = new CategoryRepository(); //öncelikle kullanacağımız repositoryden bir nesne türetiriz
		
		public async Task <IActionResult> Index()
		{
			return View(await categoryRepository.TListAsync());//daha sonra genetic repodaki isteidğimiz metodu çağırabiliriz.
		}

		[HttpGet]
		public IActionResult CategoryAdd()
		{
			return View();
		}
		[HttpPost]
public async Task<IActionResult> CategoryAdd(Category _category)
{
    _category.status = true; // Yeni eklenen kategori varsayılan olarak aktif olsun
    ModelState.Remove("status"); // Validasyondan bu alanı muaf tut
    ModelState.Remove("Foods");  // İlişkili listeyi validasyondan muaf tut

    if(!ModelState.IsValid)
    {
        return View("CategoryAdd");
    }
    await categoryRepository.TFindAsync(_category.CategoryID);
    return RedirectToAction("Index");
}
		public async Task <IActionResult> CategoryFind(int id)
		{
			var x = await categoryRepository.TFindAsync(id);
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
		public async Task<IActionResult> CategoryUpdate(Category _category)
		{
			var x = await categoryRepository.TFindAsync(_category.CategoryID);
			x.CategoryName = _category.CategoryName;
			x.CategoryDesc = _category.CategoryDesc;
			x.status = true;
			await categoryRepository.TUpdateAsync(x);
			return RedirectToAction("Index");
		}
		public async Task<IActionResult> CategoryRemove(int id)
		{
			var x = await categoryRepository.TFindAsync(id);
			x.status = false;//silme işlemini iliklili tablolarda statüyü false yaparak yapıyoruz
			await categoryRepository.TUpdateAsync(x);
			return RedirectToAction("Index");
		}
	}
}
