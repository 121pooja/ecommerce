using Ecommerce.DataAccess.IRepository;
using Ecommerce.Models.Models;


namespace Ecommerce.Repository.IRepository
{
    public interface ICartRepository : IRepository<Cart>
    {
        public Cart Update(Cart cart);
    }
}

