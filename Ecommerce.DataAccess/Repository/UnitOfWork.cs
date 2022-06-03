using Ecommerce.DataAccess.IRepository;
using Ecommerce.Models.Models;
using Ecommerce.Repository.IRepository;
using Ecommerce.Repository.Repository;

namespace Ecommerce.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext DbContext;
        public UnitOfWork(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
            User = new UserRepository(DbContext);
            Product = new ProductRepository(DbContext);
            Cart =new CartRepository(DbContext);
           Order = new OrderRepository(DbContext);


        }
        public IUserRepository User { get; private set; }
        public IProductRepository Product { get; private set; }
        public ICartRepository Cart { get; private set; }
        public IOrderRepository Order { get; private set; }

        public void Save()
        {
            DbContext.SaveChanges();
        }
    }
}
