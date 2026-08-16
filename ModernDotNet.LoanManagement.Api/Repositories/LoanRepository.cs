using ModernDotNet.LoanManagement.Api.Models;

namespace ModernDotNet.LoanManagement.Api.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        public Task<LoanSummary?> GetLoanSummaryAsync(int loanId, CancellationToken cancellationToken)
        {
            var loanSummary = new LoanSummary(
                               loanId,
                               "John Smith",
                               50000m,
                               25000m);
            return Task.FromResult<LoanSummary?>(loanSummary);
        }
    }
}
