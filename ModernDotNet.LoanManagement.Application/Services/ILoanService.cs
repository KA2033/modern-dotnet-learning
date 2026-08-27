using ModernDotNet.LoanManagement.Application.Models;

namespace ModernDotNet.LoanManagement.Application.Services
{
    public interface ILoanService
    {
        Task<LoanSummary?> GetLoanSummaryAsync(
        int loanId,
        CancellationToken cancellationToken);
    }
}
