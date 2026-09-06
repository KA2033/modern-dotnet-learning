using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ModernDotNet.LoanManagement.Application.DTOs
{
    public class MakePaymentRequestDto
    {
        [Range(typeof(decimal), "0.01", "9999999999999999.99")]
        public decimal PaymentAmount { get; set; }
    }
}
