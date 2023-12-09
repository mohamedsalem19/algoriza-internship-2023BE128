

namespace Vezeeta.Infrastructure.EntityConfigration
{
    internal class DoctorConfigration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.Property(I => I.Price).HasColumnType("decimal(18,2)");

        }


    }

}
