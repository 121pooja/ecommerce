using Ecommerce.DataAccess.IRepository;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly ApplicationDbContext DbContext;
        public UserRepository(ApplicationDbContext dbContext): base(dbContext)
        {
            DbContext = dbContext;
        }

        public void Save()
        {
            DbContext.SaveChanges();
        }

        public User Update(User user)
        {
            DbContext.Update(user);
            return user;
        }
    }
}
