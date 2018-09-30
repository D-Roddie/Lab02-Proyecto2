namespace Entities
{
    public class Address:BaseEntity
    {
        public string IDCustomer { get; set; }
        public string Province { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
    }
}