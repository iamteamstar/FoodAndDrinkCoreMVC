using FoodAndDrinkWithCore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodAndDrinkWithCore.Repositories
{
	public class GenericRepository<T> where T:class//generic repo bir değer,bir isim alır bu ismi döndürür(T,Table...) bu generic repo ile ilgli bir şart vardı bu T değeri mutlaka class olmak zorunda ve new anahtar sözcüğünü barındırmalıdır
	{
		//food ve category repositorylerinde hazırlamış olduğumuz metotları buraya bir iskelet yapısı şeklinde hazırlamış olacağız
		/*Oluşturulan Repositorylerde paramaetre olarak sınıftan değer alıyorduk yani kullanacağımız tablo hangisiyse ondan nesne üretiyorduk mesela
		public void CategoryRemove(Category _category)
		{

			context.categories.Remove(_category);
			context.SaveChanges();
		}

		Artık değerlerimi T değerinden alıyor olacağız

		Sınıfı görmüş olduğumuz yerlere: return context.categories.ToList(),context.categories.Add(_category);
		context.categories.Add(_category),context.categories.Add(_category),context.categories.Find(id) kısımlarındaki categories kısımları
		erine artık Set<T>() Atamış olacağız
		 */
		//5 temel crud işleminin tamamını birer metot olarak burada tanımlayacağız:listeleme,ekleme,silme,güncelleme,getirme
		Context context = new Context();
		public List<T> TList()
		{
			return context.Set<T>().ToList();//listeleme işlemimiz bu şekilde olacak

		}
		public void TAdd(T p)
		{
			context.Set<T>().Add(p);
			context.SaveChanges();
		}
		public void TRemove(T p)
		{

			context.Set<T>().Remove( p);
			context.SaveChanges();
		}
		public void TUpdate(T p)
		{
			context.Set<T>().Update(p);
			context.SaveChanges();
		}
		public T TFind(int id)
		{
		return	context.Set<T>().Find(id);
		}
		public List<T>TList(string p)//food tablosunda category name veya categorye ait her şeyi gösterebilmek için. aynı işlemi yanı category sınıfında da food değerlerini gösterebiliriz
		{
			return context.Set<T>().Include(p).ToList();
		}
			
			//Artık food repositoryden bir şey almamıza gerek kalmadı onun
		//içindekileri sildik. şimdi devreye bu generic repoyu her yerde kullanmak için kalıtım giriyor

	}
}
