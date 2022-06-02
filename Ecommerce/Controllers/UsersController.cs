using Ecommerce.DataAccess;
using Ecommerce.DataAccess.IRepository;
using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
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
        public User GetUser([FromQuery] string Email, string Password)
        {
            var User = UnitOfWork.User.GetFirstOrDefault(u=>u.Email == Email);
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
        public User UpdateUser([FromBody] User User)
        {
            var Users = UnitOfWork.User.Update(User);
            UnitOfWork.Save();
            return User;
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
