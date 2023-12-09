


namespace Vezeeta.Core.Entities
{
    public class User : IdentityUser<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Image { get; set; }


        public Genders Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }


    }
}
