namespace Entities
{
    public class Loans: BaseEntity
    {
        public string LoansID { get; set; }
        public string Amount { get; set; }
        public string Rate { get; set; }
        public string LoanName { get; set; }
        public string Share { get; set; }
        public string StartDate { get; set; }
        public string Status { get; set; }
        public string BalanceOperation { get; set; }
    }
}