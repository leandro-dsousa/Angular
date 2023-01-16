using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project1.Domain.Post;

namespace Project1.Infraestructure
{
    internal class PostEntityTypeConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts");
            builder.HasKey(x => x.Id);
            builder.OwnsOne(x => x.Title).Property(x=>x._title).HasColumnName("Title");
            builder.OwnsOne(x => x.Description).Property(x => x._description).HasColumnName("Description"); ;
            builder.OwnsOne(x => x.Author).Property(x => x._author).HasColumnName("Author"); ;
            builder.OwnsOne(x => x.Url).Property(x => x._url).HasColumnName("Url"); ;
        }
    }
}
