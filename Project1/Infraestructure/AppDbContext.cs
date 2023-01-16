using Microsoft.EntityFrameworkCore;
using Project1.Domain.Post;

namespace Project1.Infraestructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostEntityTypeConfiguration());
        }
    }
}
