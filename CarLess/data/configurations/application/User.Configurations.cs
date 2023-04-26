using core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace data.Configuration.Application
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_user");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.FirstName).HasColumnName("first_name");
            builder.Property(x => x.LastName).HasColumnName("last_name");
            builder.Property(x => x.Email).HasColumnName("email");
            builder.Property(x => x.PassWord).HasColumnName("password");

            builder.HasMany(x => x.Rentals)
                .WithOne(x => x.User);
        }
    }
}