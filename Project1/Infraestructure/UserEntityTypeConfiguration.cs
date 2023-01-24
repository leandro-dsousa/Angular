using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project1.Domain.Post;
using Project1.Domain.User;

namespace Project1.Infraestructure
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);
            builder.OwnsOne(x => x.Name).Property(x => x._name).HasColumnName("Name");
            builder.OwnsOne(x => x.Email).Property(x => x._email).HasColumnName("Email");
            builder.OwnsOne(x => x.Password).Property(x => x._password).HasColumnName("Password");
        }
    }
}
