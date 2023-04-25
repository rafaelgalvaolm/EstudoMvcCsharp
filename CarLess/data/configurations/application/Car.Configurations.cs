using core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace data.Configuration.Application
{
    public class CarConfigurations : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("cars", "dbo");

            builder.HasKey(x => x.car_id).HasName("pk_car");

            builder.Property(x => x.car_id).ValueGeneratedOnAdd().HasColumnName("car_id");
            builder.Property(x => x.make).HasColumnName("make");
            builder.Property(x => x.model).HasColumnName("model");
            builder.Property(x => x.year).HasColumnName("year");
            builder.Property(x => x.price_per_day).HasColumnName("price_per_day");

            builder.HasMany(x => x.Rentals)
                .WithOne(x => x.Car);
        }
    }
}

