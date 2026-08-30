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
            if(string.IsNullOrWhiteSpace(customerName))
            {
                throw new ArgumentNullException("Customer name is required",nameof(customerName));
            }
            if(principalAmount <= 0)
            {
                throw new ArgumentOutOfRangeException("Principal amount must be greater than zero", nameof(principalAmount));
            }
            if(interestRate < 0 || interestRate > 100)
            {
                throw new ArgumentOutOfRangeException("Interest rate must be between 0 and 100", nameof(interestRate));
            }
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
