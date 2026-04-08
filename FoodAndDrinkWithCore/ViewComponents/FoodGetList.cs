using FoodAndDrinkWithCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FoodAndDrinkWithCore.ViewComponents
{
	public class FoodGetList:ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			FoodRepository foodRepository = new FoodRepository();
			var foodList = await foodRepository.TListAsync();
			return View(foodList);
		}
	}
}
