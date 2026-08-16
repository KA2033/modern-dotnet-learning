using ModernDotNet.LoanManagement.Api.Models;
using ModernDotNet.LoanManagement.Api.Repositories;

namespace ModernDotNet.LoanManagement.Api.Services
{
    public class LoanService : ILoanService
    {
        private readonly ILoanRepository _repository;

        public LoanService(ILoanRepository repository)
        { 
            _repository = repository;
        }
        public async Task<LoanSummary?> GetLoanSummaryAsync(int loanId, CancellationToken cancellationToken)
        {
            return await _repository.GetLoanSummaryAsync(loanId, cancellationToken);
        }
    }
}
