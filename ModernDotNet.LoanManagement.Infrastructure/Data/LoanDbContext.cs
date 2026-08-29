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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Loan>(entity =>
            {
                entity.HasKey(e => e.LoanId);

                entity.Property(e => e.CustomerName)
                    .IsRequired();

                entity.Property(e => e.PrincipalAmount)
                    .HasPrecision(18, 2);

                entity.Property(e => e.InterestRate)
                    .HasPrecision(5, 2);

                entity.Property(e => e.OutstandingAmount)
                    .HasPrecision(18, 2);

                entity.Property(e => e.TotalPaid)
                    .HasPrecision(18, 2);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}

