using Microsoft.EntityFrameworkCore;
using Project1.Domain.User;
using Project1.Infraestructure;
using System;

namespace Project1.Repositories.User
{
    public class UserRepository : IUserRepository
    {

        private readonly AppDbContext _context;
        private readonly DbSet<Domain.User.User> _objs;

        public UserRepository(AppDbContext context)
        {
            _context = context;
            _objs = context.Users;
        }

        public Domain.User.User AddUser(Domain.User.User user)
        {
            if (_objs.Where(p => p.Id == user.Id).FirstOrDefault() == null)
            {
                _objs.Add(user);
                _context.SaveChanges();
            } else
            {
                throw new InvalidOperationException("User already exists");
            }
            
            return user;
        }

        public Task<Domain.User.User?> GetUserById(Guid guid)
        {
            return _objs.Where(p => p.Id == guid).FirstOrDefaultAsync();
        }

        public IEnumerable<Domain.User.User> GetUsers()
        {
            return _objs;
        }
    }
}
