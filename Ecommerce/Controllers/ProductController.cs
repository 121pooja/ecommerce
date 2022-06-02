using Ecommerce.DataAccess.IRepository;
using Ecommerce.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork UnitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("api/Product/GetAllProducts")]
        public IEnumerable<Product> GetAllProducts()
        {
            var products = UnitOfWork.Product.GetAll();
            return products;
        }

        [HttpGet]
        [Route("api/Product/GetProduct")]
        public Product GetProduct([FromQuery] int Id)
        {
            var product = UnitOfWork.Product.GetFirstOrDefault(u => u.Id == Id);
            return product;
        }

        [HttpPost]
        [Route("api/Product/AddProduct")]
        public Product AddProduct([FromBody] Product obj)
        {
            var product = UnitOfWork.Product.Add(obj);
            UnitOfWork.Save();
            return product;
        }

        [HttpPost]
        [Route("api/Product/EditProduct")]
        public Product EditProduct([FromBody] Product obj)
        {
            var product = UnitOfWork.Product.Update(obj);
            UnitOfWork.Save();
            return product;
        }

        [HttpPost]
        [Route("api/Product/DeleteProduct/{Id}")]
        public Product DeleteProduct(int Id)
        {
            var product = UnitOfWork.Product.GetFirstOrDefault(u => u.Id == Id);
            UnitOfWork.Product.Delete(product);
            UnitOfWork.Save();
            return product;
        }
    }
}
