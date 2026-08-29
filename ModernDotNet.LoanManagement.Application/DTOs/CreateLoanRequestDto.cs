using System;
using System.Collections.Generic;
using System.Text;

namespace ModernDotNet.LoanManagement.Application.DTOs
{
    public class CreateLoanRequestDto
    {
        public string CustomerName { get; set; } = string.Empty;

        public decimal PrincipalAmount { get; set; }

        public decimal InterestRate { get; set; }
    }
}
