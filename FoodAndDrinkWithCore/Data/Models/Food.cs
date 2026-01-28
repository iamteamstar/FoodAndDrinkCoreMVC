using System.ComponentModel.DataAnnotations;

namespace FoodAndDrinkWithCore.Data.Models
{
	public class Food
	{
		public int FoodID { get; set; }
		[Required(ErrorMessage ="food name not null")]
		[StringLength(20,ErrorMessage ="plese max enter 20 characters")]
		public string FoodName { get; set; }
		[Required(ErrorMessage = "food description not null")]
		[StringLength(50, ErrorMessage = "plese max enter 50 characters")]
		public string FoodDesc { get; set; }//yiyeceğin vitrin açıklaması
		[Required(ErrorMessage = "food price not null")]
		[Range(1,300,ErrorMessage = "Plese only enter 1 beetwen 180 range a number")]
		public double FoodPrice { get; set; }
		[Required(ErrorMessage = "food description not null")]
		[StringLength(50, ErrorMessage = "plese max enter 50 characters")]
		public string FoodImageUrl { get; set; }
		[Required(ErrorMessage = "food stock not null")]
		[Range(1, 180, ErrorMessage = "Plese only enter 1 beetwen 180 range a number")]
		public int FoodStock { get; set; }
		public int CategoryID { get; set; }
		public virtual Category Category { get; set; }//bire çok ilişki kurduk. bu tarz önce nesne üretip ilişki kuruyosak bu şu demek bir yiyeceğin sadece bir kategorisi olabilir
	}
}
