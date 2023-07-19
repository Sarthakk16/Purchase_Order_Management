using Microsoft.EntityFrameworkCore;

namespace POM_trial.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        private readonly ApplicationDbContext _db;

        public HomeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Category>> Categories()
        {
            return await _db.Categories.ToListAsync();
        }

        

        public async Task<IEnumerable<Product>> GetProducts(string sTerm = "", int CategoryId = 0)
        {
           /* sTerm = sTerm.ToLower();*/
            IEnumerable<Product> Products = await (from Product in _db.Products
                         join Category in _db.Categories
                         on Product.CategoryId equals Category.Id
                         where string.IsNullOrWhiteSpace(sTerm) || (Product != null && Product.Product_Name.ToLower().StartsWith(sTerm))
                         select new Product
                         {
                             Id = Product.Id,
                             Product_Name= Product.Product_Name,
                             Image=Product.Image,
                             Purchase_Price= Product.Purchase_Price,
                             MRP = Product.MRP,
                             Name = Category.Name,
                             CategoryId= Product.CategoryId,
                             Unit = Product.Unit

                             
                             
                             
                         }
                         ).ToListAsync();
            if (CategoryId > 0)
            {

                Products = Products.Where(a => a.CategoryId == CategoryId).ToList();
            }
            return Products;

        }

        
    }

    
}
