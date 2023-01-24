using System.Text.RegularExpressions;

namespace Project1.Domain.User
{
    public class Email
    {

        public string _email { get; set; }

        public Email()
        {

        }

        public Email(string email) {
            if (Regex.IsMatch("/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\\.[a-zA-Z0-9-]+)*$/.", email))
            {
                _email = email;
            } else { 
                throw new InvalidOperationException("Email doesn't fulfill the format requirements.");
            }
        }
    }
}
