
using Microsoft.AspNetCore.Mvc;
using Ecommerce.DataAccess.IRepository;
using Ecommerce.Models.Models;


namespace Ecommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    
    public class OrderController : ControllerBase
    {
        private readonly IUnitOfWork UnitOfWork;

        public OrderController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("api/Order/GetAllOrders")]
        public IEnumerable<Order> GetAllOrders()
        {
            var orders = UnitOfWork.Order.GetAll();
            return orders;
        }

        [HttpGet]
        [Route("api/Order/GetOrder")]
        public Order GetOrder([FromQuery] int Id)
        {
            var order = UnitOfWork.Order.GetFirstOrDefault(u => u.Id == Id);
            return order;
        }

        [HttpPost]
        [Route("api/Order/AddOrder")]
        public Order AddOrder([FromBody] Order obj)
        {
            var order = UnitOfWork.Order.Add(obj);
            UnitOfWork.Save();
            return order;
        }

        [HttpPost]
        [Route("api/Order/EditOrder")]
        public Order EditOrder([FromBody] Order obj)
        {
            var order = UnitOfWork.Order.Update(obj);
            UnitOfWork.Save();
            return order;
        }

        [HttpPost]
        [Route("api/Order/DeleteOrder/{Id}")]
        public Order DeleteOrder(int Id)
        {
            var order = UnitOfWork.Order.GetFirstOrDefault(u => u.Id == Id);
            UnitOfWork.Order.Delete(order);
            UnitOfWork.Save();
            return order;
        }
    }
}
