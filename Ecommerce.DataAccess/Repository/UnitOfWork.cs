using Ecommerce.DataAccess.IRepository;
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
        }
        public IUserRepository User { get; private set; }
        public IProductRepository Product { get; private set; }

        public void Save()
        {
            DbContext.SaveChanges();
        }
    }
}
