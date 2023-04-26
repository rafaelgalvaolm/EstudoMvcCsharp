using core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace data.Configuration.Application
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_usuario");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.FirstName).HasColumnName("first_name");
            builder.Property(x => x.LastName).HasColumnName("last_name");
            builder.Property(x => x.Email).HasColumnName("email");
            builder.Property(x => x.PassWord).HasColumnName("password");

            builder.HasMany(x => x.Rentals)
                .WithOne(x => x.Usuario));
        }
    }
}