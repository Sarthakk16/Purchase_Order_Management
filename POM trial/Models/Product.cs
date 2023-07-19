using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace POM_trial.Models
	{
		[Table("Product")]
		public class Product
		{

			public int Id { get; set; }

			[Required]
			[MaxLength(100)]
			public string? Product_Name { get; set; }
			[Required]
			public string Product_Description { get; set; }
			[Required]
			public string? Image { get; set; }
			[Required]
			public double MRP { get; set; }
			[Required]
			public double Purchase_Price { get; set; }
			[Required]
			public int HSN_Code { get; set; }
			[Required]

			public string Unit { get; set; }
			[Required]

			public int CategoryId { get; set; }
			public Category Category { get; set; }

			public List<OrderDetail> OrderDetail { get; set; }
			public List<CartDetail> CartDetail { get; set; }

			[NotMapped]
			public string Name { get; set; }



		}
	}


