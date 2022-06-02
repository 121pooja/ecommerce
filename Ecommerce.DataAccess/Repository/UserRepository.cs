using Ecommerce.DataAccess.IRepository;
using Ecommerce.Models;
using Ecommerce.DataAccess;
using Ecommerce.DataAccess.Repository;
using Ecommerce.Repository.IRepository;

namespace Ecommerce.DataAccess.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly ApplicationDbContext DbContext;
        public UserRepository(ApplicationDbContext dbContext): base(dbContext)
        {
            DbContext = dbContext;
        }

        public User Update(User obj)
        {
            var user = DbContext.Users.FirstOrDefault(u => u.Id == obj.Id);
            if (user != null)
            {
               user.FirstName = obj.FirstName;
               user.LastName = obj.LastName;
               user.ImgUrl = obj.ImgUrl;
               user.Email = obj.Email;
               user.Phone = obj.Phone;
               user.Password = obj.Password;
            }
            return user;
        }
    }
}
