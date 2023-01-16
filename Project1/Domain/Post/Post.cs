using System.ComponentModel.DataAnnotations;

namespace Project1.Domain.Post
{
    public class Post
    {
        [Key]
        public Guid Id { get; set; }
        public Description Description { get; set; }
        public Author Author { get; set; }
        public Title Title { get; set; }
        public Url Url { get; set; }

        public Post()
        {
            //For ORM            
        }

        public Post(Guid guid, string description, string author, string title, string url)
        {
            Id = guid;
            Description = new Description(description);
            Author = new Author(author);
            Title = new Title(author);
            Url = new Url(url);
        }
    }
}
