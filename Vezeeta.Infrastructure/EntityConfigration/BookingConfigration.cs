

namespace Vezeeta.Infrastructure.EntityConfigration
{
    public class BookingConfigration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.Property(I => I.TotalPrice).HasColumnType("decimal(18,2)");

        }


    }
}
