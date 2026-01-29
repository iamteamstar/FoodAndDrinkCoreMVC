using FoodAndDrinkWithCore.Data;
using FoodAndDrinkWithCore.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodAndDrinkWithCore.Controllers
{
	public class ChartController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Index2()
		{
			return View();
		}
		// google chartlarda ilk başta statik bir veri girişi yapılır. verileri burdan bir metodun içerisine oradan da viewe yollayıp oradan ekrana bastırılır. bunun için önde bir sınıf eklenir
		public IActionResult VisualizeProductResult()//ürün sonuçlarını görselleştir
		{
			return Json(ProList());
		}
		public List<ChartClass>ProList()
		{
			List<ChartClass> cs = new List<ChartClass>();
			cs.Add(new ChartClass()
			{
				ProductName = "Computer",
				ProductCounter = 150
			}
				);
			cs.Add(new ChartClass()
			{
			ProductName="Lcd",
			ProductCounter=75
			});
			cs.Add(new ChartClass()
			{
				ProductName = "USB Disk",
				ProductCounter = 220
			});
			return cs;
		}
		public IActionResult Index3()
		{
			return View();
		}
		public IActionResult Index4()
		{
			return View();
		}
		public IActionResult VisualizeProductResult2()
		{
			return Json(FoodList());
		}
		public List<DynamicChartClass> FoodList()
		{
			List<DynamicChartClass> cs2 = new List<DynamicChartClass>();
			using (var c = new Context())
			{
				cs2 = c.foods.Select(x => new DynamicChartClass
				{
					FoodName = x.FoodName,
					FoodStock = x.FoodStock
				}).ToList();
			}
				return cs2;
		}

		
	}
}
