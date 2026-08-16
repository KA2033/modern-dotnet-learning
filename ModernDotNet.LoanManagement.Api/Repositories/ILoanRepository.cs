using ModernDotNet.LoanManagement.Api.Models;

namespace ModernDotNet.LoanManagement.Api.Repositories
{
    public interface ILoanRepository
    {   
        Task<LoanSummary?> GetLoanSummaryAsync(
        int loanId,
        CancellationToken cancellationToken);
    }
}
