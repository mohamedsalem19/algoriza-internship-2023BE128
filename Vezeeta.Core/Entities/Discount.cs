

namespace Vezeeta.Core.Entities
{
    public class Discount : BaseEntity
    {


        public string Code { get; set; }
        public bool IsActive { get; set; }
        public int NumberOfRequests { get; set; }
        public DiscountTypes DiscountTypes { get; set; }
        public float Value { get; set; }
    }
}
