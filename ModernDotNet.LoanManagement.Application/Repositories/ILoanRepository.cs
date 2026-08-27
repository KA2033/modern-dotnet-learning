using ModernDotNet.LoanManagement.Application.Models;

namespace ModernDotNet.LoanManagement.Application.Repositories
{
    public interface ILoanRepository
    {   
        Task<LoanSummary?> GetLoanSummaryAsync(
        int loanId,
        CancellationToken cancellationToken);
    }
}
