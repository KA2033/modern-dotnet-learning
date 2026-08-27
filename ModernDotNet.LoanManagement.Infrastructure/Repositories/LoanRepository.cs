using ModernDotNet.LoanManagement.Application.Models;
using ModernDotNet.LoanManagement.Infrastructure.Data;
using ModernDotNet.LoanManagement.Application.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ModernDotNet.LoanManagement.Infrastructure.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly LoanDbContext _context;

        public LoanRepository(LoanDbContext context)
        {
            _context = context;
        }
        public async Task<LoanSummary?> GetLoanSummaryAsync(int loanId, CancellationToken cancellationToken)
        {
            //var loanSummary = new LoanSummary(
            //                   loanId,
            //                   "John Smith",
            //                   50000m,
            //                   25000m);
            //return Task.FromResult<LoanSummary?>(loanSummary);
            var loan = await _context.Loans.AsNoTracking().FirstOrDefaultAsync(x => x.LoanId == loanId, cancellationToken);

            if(loan is null)
            {
                return null;
            }
            return new LoanSummary(loan.LoanId, loan.CustomerName, loan.OutstandingAmount, loan.TotalPaid);
        }
    }
}
