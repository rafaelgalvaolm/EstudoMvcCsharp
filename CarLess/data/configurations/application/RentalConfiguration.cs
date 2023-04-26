using core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace data.Configuration.Application
{
    public class RentalConfiguration : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.ToTable("rental", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_rental");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("rental_id");
            builder.Property(x => x.CarId).HasColumnName("car_id");
            builder.Property(x => x.UserId).HasColumnName("user_id");
            builder.Property(x => x.RentalStartDate).HasColumnName("rental_start_date");
            builder.Property(x => x.RentalEndDate).HasColumnName("rental_end_date");
            builder.Property(x => x.RentalCost).HasColumnName("rental_cost");

            builder.HasOne(x => x.Car)
                .WithMany(x => x.Rentals)
                .HasForeignKey(x => x.CarId)
                .HasConstraintName("fk_car_id");

            builder.HasOne(x => x.User)
            .WithMany(x => x.Rentals)
            .HasForeignKey(x => x.UserId)
            .HasConstraintName("fk_user_id");
        }
    }
}