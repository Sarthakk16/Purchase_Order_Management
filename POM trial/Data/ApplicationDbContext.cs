using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using POM_trial.Models;

namespace POM_trial.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

		public DbSet<Category> Categories{ get; set; }

		public DbSet<Product> Products { get; set; }

		public DbSet<ShoppingCart> ShoppingCarts { get; set; }
		public DbSet<CartDetail> CartDetails { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }

		public DbSet<OrderStatus> OrderStatuses { get; set; }

       


    }
}
