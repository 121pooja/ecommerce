using Ecommerce.DataAccess.IRepository;
using Ecommerce.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IUnitOfWork UnitOfWork;

        public CartController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("api/Cart/GetAllCarts")]
        public IEnumerable<Cart> GetAllCarts()
        {
            var carts = UnitOfWork.Cart.GetAll();
            return carts;
        }

        [HttpGet]
        [Route("api/Cart/GetCart")]
        public Cart GetCart([FromQuery] int Id)
        {
            var cart = UnitOfWork.Cart.GetFirstOrDefault(u => u.Id == Id);
            return cart;
        }

        [HttpPost]
        [Route("api/Cart/AddCart")]
        public Cart AddProduct([FromBody] Cart obj)
        {
            var cart = UnitOfWork.Cart.Add(obj);
            UnitOfWork.Save();
            return cart;
        }

        [HttpPost]
        [Route("api/Cart/EditCart")]
        public Cart EditProduct([FromBody] Cart obj)
        {
            var cart= UnitOfWork.Cart.Update(obj);
            UnitOfWork.Save();
            return cart;
        }

        [HttpPost]
        [Route("api/Cart/DeleteCart/{Id}")]
        public Cart DeleteCart(int Id)
        {
            var cart= UnitOfWork.Cart.GetFirstOrDefault(u => u.Id == Id);
            UnitOfWork.Cart.Delete(cart);
            UnitOfWork.Save();
            return cart;
        }
    }
}

