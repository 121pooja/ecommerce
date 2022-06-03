using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.DataAccess;
using Ecommerce.DataAccess.Repository;
using Ecommerce.Models.Models;
using Ecommerce.Repository.IRepository;

namespace Ecommerce.Repository.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository 
    {

     private readonly ApplicationDbContext DbContext;
        public OrderRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            DbContext = dbContext;
        }

        public Order Update(Order obj)
        {
            var order = DbContext.Orders.FirstOrDefault(u => u.Id == obj.Id);
            if (order != null)
            {
               order.Id = obj.Id;
               order.UserId = obj.UserId;
               order.ItemId = obj.ItemId;
        order.PaymentId = obj.PaymentId;
        order.Delivered = obj.Delivered;
                
            }
            return order;
        }
    }
}
