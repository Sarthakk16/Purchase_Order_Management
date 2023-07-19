namespace POM_trial.Models.DTOs
{
    public class ProductDisplayModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Product { get; internal set; }
        
        
        public string STerm { get; set; } = "";
        public int CategoryId { get; set; } = 0;
    }
}

    
