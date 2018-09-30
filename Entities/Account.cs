namespace Entities
{
    public class Account : BaseEntity
    {
        public string Identification { get; set; }
        public string AccoutNumber { get; set; }
        public string Currency { get; set; }
        public string AccountName { get; set; }
        public int Balance { get; set; }
        public string ApertureDate { get; set; }
        public string State { get; set; }
        public string CustomerAccountNumber { get; set; }
    }
}