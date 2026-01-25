using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodAndDrinkWithCore.Data.Models
{
	public class Category
	{
		[Key]
		[Required]
		public int CategoryID { get; set; }
		[Column(TypeName ="varchar(25)")]
		public string CategoryName { get; set; }
		[Column(TypeName = "varchar(25)")]
		public string CategoryDesc { get; set; }
		public List<Food> Foods { get; set; }//bir kategorinin birden çok yiyeceği olabilir List varsa şu anlama gelir: bir kategoride birden çok yiyecek olabilir
	}
}
