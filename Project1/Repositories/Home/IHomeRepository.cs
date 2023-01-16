using Microsoft.AspNetCore.Mvc;
using Project1.Domain.Post;

namespace Project1.Repositories.Home
{
    public interface IHomeRepository
    {
        public IEnumerable<Post> GetPosts();

        public Task<Post?> GetPostById(Guid id);

        public IEnumerable<Post> GetPostsByAuthor(string author);

    }

}
