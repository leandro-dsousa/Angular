using Project1.Domain.Post;
using Project1.Domain.User;
using Project1.Repositories.User;

namespace Project1.Services
{
    public class UserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository repository)
        {
            userRepository = repository;
        }

        public async Task<User?> GetUserById(Guid guid) => await userRepository.GetUserById(guid) ?? new User();

        public async Task<IEnumerable<User>> GetUsers() => userRepository.GetUsers();

        public async Task<User> AddUser(User user)
        {
            return userRepository.AddUser(user);
        }
    }
}
