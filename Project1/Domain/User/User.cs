using System.ComponentModel.DataAnnotations;

namespace Project1.Domain.User
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Name Name { get; set; }
        [Required]
        public Password Password { get; set; }
        [Required]
        public Email Email { get; set; }

        public User()
        {
            //For ORM            
        }

        public User(Guid guid, string name, string password)
        {
            Id = guid;
            Name = new Name(name);
            Password = new Password(password);

        }
    }
}
