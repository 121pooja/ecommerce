using Ecommerce.DataAccess.IRepository;
using Ecommerce.Models.Models;

namespace Ecommerce.Repository.IRepository
{
    public interface IProductRepository: IRepository<Product>
    {
        public Product Update(Product product);
    }
}
