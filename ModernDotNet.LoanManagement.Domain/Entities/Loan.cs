namespace ModernDotNet.LoanManagement.Domain.Entities
{
    public class Loan
    {
        public int LoanId { get; set; }

        public string CustomerName { get; set; } = string.Empty;

        public decimal PrincipalAmount { get; set; }

        public decimal InterestRate { get; set; }

        public decimal OutstandingAmount { get; set; }

        public decimal TotalPaid { get; set; }
        public static Loan Create(
        string customerName,
        decimal principalAmount,
        decimal interestRate)
        {
            return new Loan
            {
                CustomerName = customerName,
                PrincipalAmount = principalAmount,
                InterestRate = interestRate,
                OutstandingAmount = principalAmount,
                TotalPaid = 0
            };
        }
    }
}
