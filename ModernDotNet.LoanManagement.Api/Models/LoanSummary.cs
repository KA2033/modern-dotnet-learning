namespace ModernDotNet.LoanManagement.Api.Models;

public record LoanSummary(
    int LoanId,
    string CustomerName,
    decimal OutstandingAmount,
    decimal TotalPaid);