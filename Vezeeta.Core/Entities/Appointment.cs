

namespace Vezeeta.Core.Entities
{
    public class Appointment : BaseEntity
    {

        public Days Days { get; set; }

        public long DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public ICollection<AppointmentTimeSlot> AppointmentTimeSlots { get; set; }

    }
}
