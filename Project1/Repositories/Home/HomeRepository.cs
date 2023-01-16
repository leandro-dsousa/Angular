using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Project1.Domain.Post;
using Project1.Infraestructure;

namespace Project1.Repositories.Home
{
    public class HomeRepository : IHomeRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Post> _objs;


        public HomeRepository(AppDbContext context)
        {
            _context = context;
            this._objs= _context.Posts;
        }

        public Task<Post?> GetPostById(Guid id) { 
            return this._objs.Where(p => p.Id == id).FirstOrDefaultAsync(); 
        }

        public IEnumerable<Post> GetPosts()
        {
            return this._objs;
        }

        public IEnumerable<Post> GetPostsByAuthor(string author)
        {
            return this._objs.Where(p => p.Author._author == author);
        }
    }
}
