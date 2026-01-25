using FoodAndDrinkWithCore.Data.Models;

namespace FoodAndDrinkWithCore.Repositories
{
	public class CategoryRepository
	{
		//5 temel crud işleminin tamamını birer metot olarak burada tanımlayacağız:listeleme,ekleme,silme,güncelleme,getirme
		Context context = new Context();
		public List<Category> CategoryList()
		{
			return context.categories.ToList();
		}
		public void CategoryAdd(Category category)
		{
			context.categories.Add(category);
			context.SaveChanges();
		}
		public void CategoryRemove(Category ct)
		{
		
			context.categories.Remove(ct);
			context.SaveChanges();
		}
		public void CategoryUpdate(Category ct)
		{
			context.categories.Update(ct);
			context.SaveChanges();								
		}
		public void CategoryFind(int id)
		{
			context.categories.Find(id);
		}

	}
}
