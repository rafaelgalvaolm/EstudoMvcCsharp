namespace data.Configuration.Application
{
    public class UsuarioConfigurations : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_usuario");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Nome).HasColumnName("nome");
            builder.Property(x => x.Sobrenome).HasColumnName("sobrenome");
            builder.Property(x => x.Email).HasColumnName("email");
            builder.Property(x => x.Senha).HasColumnName("senha");
            builder.Property(x => x.IsAdmin).HasColumnName("is_admin");

            builder.HasMany(x => x.Alugueis)
                .WithOne(x => x.Usuario);
        }
    }
}
