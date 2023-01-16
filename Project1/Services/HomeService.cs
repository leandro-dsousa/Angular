using Project1.Domain.Post;
using Project1.Repositories.Home;

namespace Project1.Services
{
    public class HomeService
    {

        private readonly IHomeRepository homeRepository;

        public HomeService(IHomeRepository repository) { 
            homeRepository = repository;
        }

        public async Task<Post?> GetPostById(Guid guid) => await homeRepository.GetPostById(guid) ?? new Post();

        public async Task<IEnumerable<Post>> GetPosts() => homeRepository.GetPosts();

        public async Task<IEnumerable<Post>> GetPostsFromAuthor(string author) => homeRepository.GetPostsByAuthor(author);
    }
}