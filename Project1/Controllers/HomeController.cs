using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1.Domain.Post;
using Project1.Services;

namespace Project1.Controllers
{
    //home
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        private readonly HomeService _service;

        public HomeController(HomeService service) {
            _service = service;
        }

        [HttpGet]
        public Task<IEnumerable<Post>> GetPosts()
        {
            return this._service.GetPosts();
        }

        [HttpGet("{id}")]
        public Task<Post?> GetPostById(Guid id) {
            return this._service.GetPostById(id);
        }

        [HttpGet("author={author}")]
        public Task<IEnumerable<Post>> GetPostById(string author)
        {
            return this._service.GetPostsFromAuthor(author);
        }
    }
}
