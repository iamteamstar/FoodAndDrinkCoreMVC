using FoodAndDrinkWithCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using FoodAndDrinkWithCore.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FoodAndDrinkWithCore.Controllers
{ 
	public class FoodController : Controller
	{
	Context c = new Context();
		FoodRepository foodRepository = new FoodRepository();

		public IActionResult Index()
		{
			return View(foodRepository.TList("Category"));//category sınıfından bir değer alacağımız için(name) parametre olarak onu yazdık
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
		public IActionResult FoodAdd(Food _food)
		{
			// Category nesnesi boş gelebilir, bu validasyonu bozmasın diye siliyoruz
			ModelState.Remove("Category");

			if (!ModelState.IsValid)
			{
				// HATA BURADAYDI: Validasyon hatası varsa listeyi tekrar doldurmalısın
				List<SelectListItem> categoryValues = (from x in c.categories.ToList()
													   select new SelectListItem
													   {
														   Text = x.CategoryName,
														   Value = x.CategoryID.ToString()
													   }).ToList();
				ViewBag.vl = categoryValues;

				return View(_food); // Verileri kaybetmemek için _food modelini geri gönder
			}

			foodRepository.TAdd(_food);
			return RedirectToAction("Index");
		}
	}
}
