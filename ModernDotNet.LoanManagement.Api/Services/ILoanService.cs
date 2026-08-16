using ModernDotNet.LoanManagement.Api.Models;

namespace ModernDotNet.LoanManagement.Api.Services
{
    public interface ILoanService
    {
        Task<LoanSummary?> GetLoanSummaryAsync(
        int loanId,
        CancellationToken cancellationToken);
    }
}
