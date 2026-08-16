using Microsoft.EntityFrameworkCore;
using ModernDotNet.LoanManagement.Api.Entities;

namespace ModernDotNet.LoanManagement.Api.Data
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
