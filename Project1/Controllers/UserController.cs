using Microsoft.AspNetCore.Mvc;
using Project1.Domain.User;
using Project1.Services;

namespace Project1.Controllers
{
    //user
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly UserService _service;

        public UserController(UserService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<IEnumerable<User>> GetUsers()
        {
            return _service.GetUsers();
        }

        [HttpPut]
        public async Task<User> AddUser(User user)
        {
            return await _service.AddUser(user);
        }

    }
}
