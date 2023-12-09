
namespace Vezeeta.Core.Entities
{
    public class Doctor : User
    {
        public Specializations Specialization { get; set; }
        public Decimal Price { get; set; }
        public ICollection<Appointment> Appointments { get; set; }


    }
}
