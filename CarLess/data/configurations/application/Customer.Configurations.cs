using core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace data.Configuration.Application
{
    public class CustomersConfigurations : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("customer", "dbo");

            builder.HasKey(x => x.customer_id).HasName("pk_customer");

            builder.Property(x => x.customer_id).ValueGeneratedOnAdd().HasColumnName("customer_id");
            builder.Property(x => x.first_name).HasColumnName("first_name");
            builder.Property(x => x.last_name).HasColumnName("last_name");
            builder.Property(x => x.email).HasColumnName("email");
            builder.Property(x => x.phone_number).HasColumnName("phone_number");

            builder.HasMany(x => x.Rentals)
                .WithOne(x => x.Customer);
        }
    }
}