using FoodAndDrinkWithCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FoodAndDrinkWithCore.ViewComponents
{
	public class CategoryGetList:ViewComponent
	{
		//parçalı kategori için kullancağız 
		public IViewComponentResult Invoke()
		{
			CategoryRepository categoryRepository = new CategoryRepository();
			var categoryList = categoryRepository.TList();
			return View(categoryList);
		}
	}
}
