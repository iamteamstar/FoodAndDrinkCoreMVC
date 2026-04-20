using FoodAndDrinkWithCore.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodAndDrinkWithCore.Controllers
{
	public class StatisticsController : Controller
	{
		private readonly Context c;
		public StatisticsController(Context context)
		{
			c = context;
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult StatisticDesign()
		{

			var totF = c.foods.Count();
			ViewBag.d1 = totF;

			var totC = c.categories.Count();
			ViewBag.d2 = totC;

			var foid = c.categories.Where(x => x.CategoryName == "Fruit").Select(y => y.CategoryID).FirstOrDefault();
			var totFruit = c.foods.Where(x => x.CategoryID == foid).Count();
			ViewBag.d3 = totFruit;

			var totVegetables = c.foods.Where(x => x.CategoryID == (c.categories.Where(x => x.CategoryName == "Vegetables").Select(y => y.CategoryID).FirstOrDefault())).Count();
			ViewBag.d4 = totVegetables;

			var totLegumes = c.foods.Where(x => x.CategoryID == (c.categories.Where(x => x.CategoryName == "Legumes").Select(y => y.CategoryID).FirstOrDefault())).Count();
			ViewBag.d5 = totLegumes;

			var totDrink = c.foods.Where(x => x.CategoryID == (c.categories.Where(x => x.CategoryName == "Drink").Select(y => y.CategoryID).FirstOrDefault())).Count();
			ViewBag.d6 = totDrink;

			var sumFood = c.foods.Sum(x => x.FoodStock);
			ViewBag.d7 = sumFood;

			var sumFoodStock = c.foods.Max(x=>x.FoodStock);
			ViewBag.d8 = sumFoodStock;

			var maxStockFood = c.foods.OrderByDescending(x => x.FoodStock).Select(y => y.FoodName).FirstOrDefault();
			ViewBag.d9 = maxStockFood;

			var minStockFood = c.foods.OrderBy(x => x.FoodStock).Select(y => y.FoodName).FirstOrDefault();//orderby oto olarak azları verir yani a dan z ye sıralar küçükten büyüğe 
			ViewBag.d10 = minStockFood;

			var foodAvg = c.foods.Average(x => x.FoodPrice).ToString("0.000");//tostring basamak sayısı
			ViewBag.d11 = foodAvg;

			var dgr = c.categories.Where(x => x.CategoryName == "Fruit").Select(y => y.CategoryID).FirstOrDefault();
			var dgrp = c.foods.Where(y => y.CategoryID == dgr).Sum(x => x.FoodStock);
			ViewBag.d12 = dgrp;

			var dgr1 = c.categories.Where(x => x.CategoryName == "Vegetables").Select(y => y.CategoryID).FirstOrDefault();
			var dgr1p = c.foods.Where(y => y.CategoryID == dgr1).Sum(x => x.FoodStock);
			ViewBag.d13 = dgr1p;

			var dgr2= c.foods.OrderByDescending(x => x.FoodPrice).Select(y => y.FoodName).FirstOrDefault();
			ViewBag.d14 = dgr2;

			return View();
		}
	}
}
