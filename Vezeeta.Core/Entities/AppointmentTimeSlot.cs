namespace Vezeeta.Core.Entities
{
    public class AppointmentTimeSlot : BaseEntity
    {

        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public long AppointmentId { get; set; }

        public Appointment Appointment { get; set; }
    }
}
