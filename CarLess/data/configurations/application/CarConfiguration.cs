using core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace data.Configuration.Application
{
    public class CarConfigurations : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("car", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_car");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Make).HasColumnName("make");
            builder.Property(x => x.Model).HasColumnName("model");
            builder.Property(x => x.Year).HasColumnName("year");
            builder.Property(x => x.PricePerDay).HasColumnName("price_per_day");

            builder.HasMany(x => x.Rentals)
                .WithOne(x => x.Car);
        }
    }
}

