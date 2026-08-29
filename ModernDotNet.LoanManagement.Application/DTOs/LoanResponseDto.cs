using System;
using System.Collections.Generic;
using System.Text;

namespace ModernDotNet.LoanManagement.Application.DTOs
{
    public record LoanResponseDto(
    int LoanId,
    string CustomerName,
    decimal OutstandingAmount,
    decimal TotalPaid);
}
