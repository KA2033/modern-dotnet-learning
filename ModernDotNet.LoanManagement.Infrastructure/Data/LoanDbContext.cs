using Microsoft.EntityFrameworkCore;
using ModernDotNet.LoanManagement.Domain.Entities;

namespace ModernDotNet.LoanManagement.Infrastructure.Data
{
    public class LoanDbContext: DbContext
    {
        public LoanDbContext(DbContextOptions<LoanDbContext> options)
        : base(options)
        {
        }

        public DbSet<Loan> Loans => Set<Loan>();
    }
}
