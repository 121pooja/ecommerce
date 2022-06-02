using Ecommerce.DataAccess.Repository;
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

    }
}
