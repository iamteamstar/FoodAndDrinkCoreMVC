using FoodAndDrinkWithCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FoodAndDrinkWithCore.ViewComponents
{
	public class CategoryGetList:ViewComponent
	{
		//parçalı kategori için kullancağız 
		public async Task <IViewComponentResult> Invoke()
		{
			CategoryRepository categoryRepository = new CategoryRepository();
			var categoryList = await categoryRepository.TListAsync();
			return View(categoryList);
		}
	}
}
