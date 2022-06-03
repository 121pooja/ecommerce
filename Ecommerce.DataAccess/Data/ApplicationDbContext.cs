using Ecommerce.DataAccess.Repository;
using Ecommerce.Models;
using Ecommerce.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.DataAccess
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
/*        public DbSet<UserRepository> userRepositories { get; set; }*/
        public DbSet<ProductBrand> ProductBrand { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductDiscount> ProductDiscount { get; set; }
        public DbSet<Product> Products { get; set; }


        public DbSet<User>Users{ get; set; }
        public DbSet<AdminUser>AdminUser{ get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<UserPayment> UserPayment{ get; set; }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItem{ get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<OrderPayment> OrderPayment { get; set; }




    }
}
