using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.DataAccess.IRepository;
using Ecommerce.Models.Models;

namespace Ecommerce.Repository.IRepository
{
    public interface IOrderRepository : IRepository<Order>
    {
        public Order Update(Order order);
    }
}


