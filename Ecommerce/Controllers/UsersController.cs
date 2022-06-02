using Ecommerce.DataAccess;
using Ecommerce.DataAccess.IRepository;
using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork UnitOfWork;

        public UsersController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("api/Users/GetAllUsers")]
        public IEnumerable<User> GetAllUsers()
        {
            var Users = UnitOfWork.User.GetAll();
            return Users;
        }

        [HttpGet]
        [Route("api/Users/GetUser")]
        public User GetUser([FromQuery] int Id)
        {
            var User = UnitOfWork.User.GetFirstOrDefault(u=>u.Id == Id);
            return User;
        }

        [HttpPost]
        [Route("api/Users/AddUser")]
        public User AddUser([FromBody] User obj)
        {
                var User = UnitOfWork.User.Add(obj);
                UnitOfWork.Save();
                return User;
        }

        [HttpPost]
        [Route("api/Users/UpdateUser")]
        public User UpdateUser([FromBody] User obj)
        {
            var Users = UnitOfWork.User.Update(obj);
            UnitOfWork.Save();
            return Users;
        }

        [HttpPost]
        [Route("api/Users/DeleteUser/{Id}")]
        public User UpdateUser(int Id)
        {
            var Users = UnitOfWork.User.GetFirstOrDefault(u=>u.Id == Id);
            UnitOfWork.User.Delete(Users);
            UnitOfWork.Save();
            return Users;
        }
    }
}
