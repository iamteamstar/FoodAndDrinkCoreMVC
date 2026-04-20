using FoodAndDrinkWithCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using FoodAndDrinkWithCore.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList.Extensions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace FoodAndDrinkWithCore.Controllers
{ 
	public class FoodController : Controller
	{
	Context c = new Context();
		FoodRepository foodRepository = new FoodRepository();
		
		public async Task<IActionResult> Index(int page = 1)
		{
			var foods = await foodRepository.TListAsync("Category");
			return View(foods.ToPagedList(page, 4));
		}
		[HttpGet]	
		public IActionResult FoodAdd()//amacımız liste nesnesi oluşturmak, daha sonra bu listedeki değerleri viewbag ile dropdowna view tarafına göndereceğiz ve oradan da verileri listelemeyi yapacağız.
		{
		List<SelectListItem> categoryValues = (from x in c.categories.ToList() //parantez ieçrisinde dropdownun içeriisnin doldurulacağı ve bu listeye atanacak öğelerin barındırılacağı propertyleri  tanımlamamız gerek yani categorynin değerlerini çağırıcağız. amacımız foodun içerisinde bu yiyeceklerin kategorisinin ne olduğunu göstermek. ondan dolayı bunu [HttpGet] attributunun içinnde çağırıcağız nedeni bu işlem sayfa yğklendiği zaman gelsin istiyoruz
											   select new SelectListItem //bana yeni bir liste öğesi oluştur
											   {
												   Text = x.CategoryName,
												   Value = x.CategoryID.ToString()
											   }
											).ToList();
		ViewBag.vl = categoryValues; //controller tarafondan view tarafına veri aktaracağız
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> FoodAdd(Food _food)
		{
			ModelState.Remove("Category");

			if (!ModelState.IsValid)
			{
				List<SelectListItem> categoryValues = (from x in c.categories.ToList()
													   select new SelectListItem
													   {
														   Text = x.CategoryName,
														   Value = x.CategoryID.ToString()
													   }).ToList();
				ViewBag.vl = categoryValues;

				return View(_food); // Verileri kaybetmemek için _food modelini geri gönder
			}

			await foodRepository.TAddAsync(_food);
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> FoodRemove(int id)
		{
			await foodRepository.TRemoveAsync(new Food { FoodID = id });
			return RedirectToAction("Index");
		}
		public async Task<IActionResult> FoodFind(int id)
		{
			var x = await foodRepository.TFindAsync(id);
			List<SelectListItem> categoryValues = (from y in c.categories.ToList()
												   select new SelectListItem
												   {
													   Text = y.CategoryName,
													   Value = y.CategoryID.ToString()
												   }).ToList();
			ViewBag.val = categoryValues;
			Food food = new Food()
			{
				FoodID = x.FoodID,
				FoodName=x.FoodName,
				FoodDesc=x.FoodDesc,
				FoodPrice=x.FoodPrice,
				FoodStock=x.FoodStock,
				CategoryID=x.CategoryID,
				FoodImageUrl=x.FoodImageUrl
			};

			return View(food);
		}
		[HttpPost]
		public async Task<IActionResult> FoodUpdate(Food _food)
		{
			var x = await foodRepository.TFindAsync(_food.FoodID);
			x.FoodName = _food.FoodName;
			x.FoodPrice = _food.FoodPrice;
			x.FoodStock = _food.FoodStock;
			x.FoodDesc = _food.FoodDesc;
			x.FoodImageUrl = _food.FoodImageUrl;
			x.CategoryID = _food.CategoryID;
			await foodRepository.TUpdateAsync(x);
			EntityEntry entry = c.Entry(x);
			Console.WriteLine($"entity state: {entry.State}");
			return RedirectToAction("Index");
		}
	}
}
