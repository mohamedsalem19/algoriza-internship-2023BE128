


namespace Vezeeta.Persistence.EntityConfigration
{
    public class DiscountEntityConfigration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder
           .HasIndex(p => p.Code)
           .IsUnique();
        }
    }
}
