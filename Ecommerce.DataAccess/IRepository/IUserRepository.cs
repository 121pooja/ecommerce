using Ecommerce.Models;
using Ecommerce.DataAccess.IRepository;

namespace Ecommerce.DataAccess.IRepository
{
    public interface IUserRepository: IRepository<User>
    {
        public User Update(User user);
    }
}




