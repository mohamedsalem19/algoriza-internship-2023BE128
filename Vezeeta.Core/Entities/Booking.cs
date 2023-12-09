

namespace Vezeeta.Core.Entities
{
    public class Booking : BaseEntity
    {

        public Doctor Doctor { get; set; }
        public long DoctorId { get; set; }

        public Patient Patient { get; set; }
        public long PatientId { get; set; }
        public RequestStatus RequestStatus { get; set; }

        public Specializations Specialization { get; set; }
        public Appointment Appointment { get; set; }
        public long AppointmentId { get; set; }
        public AppointmentTimeSlot AppointmentTimeSlot { get; set; }
        public long AppointmentTimeSlotId { get; set; }
        public Discount? Discount { get; set; } = null;
        public long? DiscountId { get; set; }
        public Decimal TotalPrice { get; set; }


    }
}
