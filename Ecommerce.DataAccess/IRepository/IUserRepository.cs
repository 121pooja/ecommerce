using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.IRepository
{
    public interface IUserRepository: IRepository<User>
    {
        public User Update(User user);
        public void Save();
    }
}
