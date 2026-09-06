using ModernDotNet.LoanManagement.Application.Models;
using ModernDotNet.LoanManagement.Application.DTOs;

namespace ModernDotNet.LoanManagement.Application.Services
{
    public interface ILoanService
    {
        Task<LoanResponseDto?> GetLoanAsync(
        int loanId,
        CancellationToken cancellationToken);

        Task<LoanResponseDto> CreateLoanAsync(
        CreateLoanRequestDto request,
        CancellationToken cancellationToken);

        Task<LoanResponseDto?> UpdateLoanAsync(int loanId, UpdateLoanRequestDto request, CancellationToken cancellationToken);
        Task<LoanResponseDto?> MakePaymentAsync(
    int loanId,
    MakePaymentRequestDto request,
    CancellationToken cancellationToken);
    }
}
