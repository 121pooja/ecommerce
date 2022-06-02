using Ecommerce.DataAccess;
using Ecommerce.DataAccess.Repository;
using Ecommerce.Models.Models;
using Ecommerce.Repository.IRepository;

namespace Ecommerce.Repository.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext DbContext;
        public ProductRepository(ApplicationDbContext dbContext): base(dbContext)
        {
            DbContext = dbContext;
        }

        public Product Update(Product obj)
        {
            var product = DbContext.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (product != null)
            {
                product.Name = obj.Name;
                product.ImgUrl = obj.ImgUrl;
                product.Price = obj.Price;
                product.Quantity = obj.Quantity;
                product.BrandId = obj.BrandId;
                product.CategoryId = obj.CategoryId;
                product.DiscountId = obj.DiscountId;
            }
            return product;
        }
    }
}
