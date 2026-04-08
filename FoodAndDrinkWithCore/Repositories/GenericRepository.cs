using FoodAndDrinkWithCore.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Threading.Tasks;

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
		public async Task<List<T>> TListAsync()
		{
			return await context.Set<T>().ToListAsync();//listeleme işlemimiz bu şekilde olacak

		}
		public async Task TAddAsync(T p)
		{
			context.Set<T>().Add(p);
			await context.SaveChangesAsync();
		}
		public async Task TRemoveAsync(T p)
		{

			context.Set<T>().Remove( p);
			await context.SaveChangesAsync();
		}
		public async Task TUpdateAsync(T p)
		{
			context.Set<T>().Update(p);
			await context.SaveChangesAsync();
		}
		public async Task<T> TFindAsync(int id)
		{
			return await context.Set<T>().FindAsync(id);
		}
		public async Task<List<T>>TListAsync(string p)//food tablosunda category name veya categorye ait her şeyi gösterebilmek için. aynı işlemi yanı category sınıfında da food değerlerini gösterebiliriz
		{
			return await context.Set<T>().Include(p).ToListAsync();
		}
			
			//Artık food repositoryden bir şey almamıza gerek kalmadı onun
		//içindekileri sildik. şimdi devreye bu generic repoyu her yerde kullanmak için kalıtım giriyor

		public async Task<List<T>> ListAsync(Expression<Func<T,bool>>filter)
		{
			return await context.Set<T>().Where(filter).ToListAsync();//list isminde bir tane metod oluşturduk bu metodum liste türünde. liste türünde olduğu için bana tablo bazlı bir sonuç geriye dönücek. Expression ifadesi ve kendi tanımladığımız filter paramateresiyle yapmak istediğimiz ; ben bu tabloda isteidğim herhangi bir sütüna göre arama işlemi yapabileyim stok ,ürün adı , kategori adı. 
			//bundan önce yukarda tanımladığımız TList metodu sadece string bir ifadeye göre arama işlemi yapmamızı sağlıyor amabiz burada category id ye göre veya ürün idye göre arama işlemi yapabiliyoruz
		}

	}
}
