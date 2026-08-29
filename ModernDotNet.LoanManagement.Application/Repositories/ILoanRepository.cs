using ModernDotNet.LoanManagement.Application.Models;
using ModernDotNet.LoanManagement.Domain.Entities;

namespace ModernDotNet.LoanManagement.Application.Repositories
{
    public interface ILoanRepository
    {   
        Task<Loan?> GetByIdAsync(
        int loanId,
        CancellationToken cancellationToken);

        Task<Loan> AddAsync(Loan loan, CancellationToken cancellationToken);
    }
}
