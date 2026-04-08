using FoodAndDrinkWithCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FoodAndDrinkWithCore.ViewComponents
{
	public class FoodListByCategory:ViewComponent
	{
		public async Task <IViewComponentResult> Invoke(int id)
		{
			
			FoodRepository foodRepository = new FoodRepository();
			var foodList = await foodRepository.ListAsync(x=>x.CategoryID==id);//bana id değişkenine göre foodList isminde tanımlamış olduğum değişkenime ürün listesini getirecek. Mesela 2 gönderdicategory listesini bize 2 category id li ürünleri göstericek
			return View(foodList);
		}

	}
}
