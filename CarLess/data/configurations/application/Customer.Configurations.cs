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

            builder.HasKey(x => x.usuario_id).HasName("pk_user");

            builder.Property(x => x.id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.first_name).HasColumnName("first_name");
            builder.Property(x => x.last_name).HasColumnName("last_name");
            builder.Property(x => x.email).HasColumnName("email");
            builder.Property(x => x.password).HasColumnName("password");

            builder.HasMany(x => x.Rentals)
                .WithOne(x => x.User);
        }
    }
}