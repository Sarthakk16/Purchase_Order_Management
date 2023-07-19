using System.ComponentModel.DataAnnotations.Schema;

namespace POM_trial.Models
{
	[Table("Category")]
	public class Category
	{
		
		public int Id { get; set; }
		
		public string Name { get; set; }

		public List<Product> Product { get; set; }


	}
}
