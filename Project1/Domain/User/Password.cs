using Project1.Domain.Post;

namespace Project1.Domain.User
{
    public class Password
    {

        public string _password { get; set; }

        public Password()
        {

        }

        public Password(string password)
        {
            _password = password;
        }

    }
}
