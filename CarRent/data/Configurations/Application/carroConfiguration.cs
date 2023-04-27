namespace data.Configuration.Application
{
    public class CarroConfigurations : IEntityTypeConfiguration<Carro>
    {
        public void Configure(EntityTypeBuilder<Carro> builder)
        {
            builder.ToTable("carro", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_carro");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Marca).HasColumnName("marca");
            builder.Property(x => x.Modelo).HasColumnName("modelo");
            builder.Property(x => x.Ano).HasColumnName("ano");
            builder.Property(x => x.PrecoDia).HasColumnName("preco_dia");

            builder.HasMany(x => x.Alugueis)
                .WithOne(x => x.Carro);
        }
    }
}
