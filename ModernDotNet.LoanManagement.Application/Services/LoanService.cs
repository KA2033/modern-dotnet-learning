using ModernDotNet.LoanManagement.Application.DTOs;
using ModernDotNet.LoanManagement.Application.Models;
using ModernDotNet.LoanManagement.Application.Repositories;
using ModernDotNet.LoanManagement.Domain.Entities;

namespace ModernDotNet.LoanManagement.Application.Services
{
    public class LoanService : ILoanService
    {
        private readonly ILoanRepository _repository;

        public LoanService(ILoanRepository repository)
        { 
            _repository = repository;
        }
        public async Task<LoanResponseDto?> GetLoanAsync(int loanId, CancellationToken cancellationToken)
        {
            var loan = await _repository.GetByIdAsync(loanId, cancellationToken);
            if (loan == null)
            {
                return null;
            }
            return new LoanResponseDto(loan.LoanId, loan.CustomerName,loan.InterestRate, loan.OutstandingAmount, loan.TotalPaid);
        }
        public async Task<LoanResponseDto> CreateLoanAsync(CreateLoanRequestDto request,CancellationToken cancellationToken)
        {
            var loan = Loan.Create(request.CustomerName, request.PrincipalAmount, request.InterestRate);
            
            var savedLoan = await _repository.AddAsync(loan,cancellationToken);
            return new LoanResponseDto(savedLoan.LoanId, savedLoan.CustomerName,savedLoan.InterestRate, savedLoan.OutstandingAmount, savedLoan.TotalPaid);
        }

        public async Task<LoanResponseDto?> UpdateLoanAsync(int loanId,UpdateLoanRequestDto request, CancellationToken cancellationToken)
        {
            var loan = await _repository.GetByIdAsync(loanId, cancellationToken);
            if (loan == null)
            {
                return null;
            }
            loan.UpdateDetails(request.CustomerName,request.InterestRate);
            var savedLoan = await _repository.UpdateAsync(loan, cancellationToken);
            return new LoanResponseDto(savedLoan.LoanId, savedLoan.CustomerName,savedLoan.InterestRate, savedLoan.OutstandingAmount, savedLoan.TotalPaid);
        }
    }
}
