using Ecommerce.Repository.IRepository;

namespace Ecommerce.DataAccess.IRepository
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; }
        IProductRepository Product { get; }
        ICartRepository Cart { get; }
        IOrderRepository Order { get; }


        void Save();
    }
}
