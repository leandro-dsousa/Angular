namespace Project1.Repositories.User
{
    public interface IUserRepository
    {
        Domain.User.User AddUser(Domain.User.User user);
        Task<Domain.User.User?> GetUserById(Guid guid);
        IEnumerable<Domain.User.User> GetUsers();
    }
}
