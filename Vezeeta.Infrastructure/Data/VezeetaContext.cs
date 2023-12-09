

namespace Vezeeta.Infrastructure.Data
{
    public class VezeetaContext : DbContext
    {
        public VezeetaContext(DbContextOptions<VezeetaContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentTimeSlot> AppointmentTimeSlots { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Discount> Discounts { get; set; }
    }
}
