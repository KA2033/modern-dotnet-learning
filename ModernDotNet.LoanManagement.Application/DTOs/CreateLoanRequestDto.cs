using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ModernDotNet.LoanManagement.Application.DTOs;

public class CreateLoanRequestDto
{
    [Required]
    [StringLength(100)]
    public string CustomerName { get; set; } = string.Empty;

    [Range(typeof(decimal), "0.01", "9999999999.99")]
    public decimal PrincipalAmount { get; set; }

    [Range(typeof(decimal), "0", "100")]
    public decimal InterestRate { get; set; }
}
