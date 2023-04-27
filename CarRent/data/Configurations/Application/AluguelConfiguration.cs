namespace data.Configuration.Application
{
    public class AluguelConfiguration : IEntityTypeConfiguration<Aluguel>
    {
        public void Configure(EntityTypeBuilder<Aluguel> builder)
        {
            builder.ToTable("aluguel", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_aluguel");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("rental_id");
            builder.Property(x => x.IdCarro).HasColumnName("id_carro");
            builder.Property(x => x.IdUsuario).HasColumnName("id_usuario");
            builder.Property(x => x.InicioAluguel).HasColumnName("inicio_aluguel");
            builder.Property(x => x.FinalAluguel).HasColumnName("final_aluguel");
            builder.Property(x => x.CustoTotal).HasColumnName("custo_total");
            builder.Property(x => x.Finalizado).HasColumnName("finalizado");

            builder.HasOne(x => x.Carro)
                .WithMany(x => x.Alugueis)
                .HasForeignKey(x => x.IdCarro)
                .HasConstraintName("fk_id_carro");

            builder.HasOne(x => x.Usuario)
            .WithMany(x => x.Alugueis)
            .HasForeignKey(x => x.IdUsuario)
            .HasConstraintName("fk_id_usuario");
        }
    }
}