namespace Entities
{
    public class Account : BaseEntity
    {
        public string Identification { get; set; }
        public string Currency { get; set; }
        public string AccountName { get; set; }
        public int Balance { get; set; }

    }
}