namespace ModernDotNet.LoanManagement.Domain.Entities
{
    public class Loan
    {
        public int LoanId { get; set; }

        public string CustomerName { get; set; } = string.Empty;

        public decimal OutstandingAmount { get; set; }

        public decimal TotalPaid { get; set; }
    }
}
