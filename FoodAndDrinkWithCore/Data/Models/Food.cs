namespace FoodAndDrinkWithCore.Data.Models
{
	public class Food
	{
		public int FoodID { get; set; }
		public string FoodName { get; set; }
		public string FoodShortDesc { get; set; }//yiyeceğin vitrin açıklaması
		public string FoodLongDesc { get; set; }//yiyexeğin detaylı açıklaması
		public double FoodPrice { get; set; }
		public string FoodImageUrl { get; set; }
		public string FoodThumbNailImageUrl { get; set; }//küçük resim
		public int FoodStock { get; set; }
		public int CategoryID { get; set; }
		public virtual Category Category { get; set; }//bire çok ilişki kurduk. bu tarz önce nesne üretip ilişki kuruyosak bu şu demek bir yiyeceğin sadece bir kategorisi olabilir
	}
}
