using Microsoft.EntityFrameworkCore;

namespace FoodAndDrinkWithCore.Data.Models
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=AzadKocakPc;User Id=sa;Password=password1;database=FoodAndDrinkWithCoreDb;TrustServerCertificate=True");//veya integrated security=true
		}
		//burada tanımlanan entity sınıfları veri tabanında tablolar olarak oluşturulacak migration islemi yapıldığında
		public DbSet<Food> foods { get; set; }
		public DbSet<Category> categories { get; set; }
	}
}
