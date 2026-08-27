namespace ModernDotNet.LoanManagement.Application.Models;

public record LoanSummary(
    int LoanId,
    string CustomerName,
    decimal OutstandingAmount,
    decimal TotalPaid);