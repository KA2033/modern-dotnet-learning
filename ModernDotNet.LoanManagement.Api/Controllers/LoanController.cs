using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModernDotNet.LoanManagement.Application.DTOs;
using ModernDotNet.LoanManagement.Application.Services;

namespace ModernDotNet.LoanManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly ILoanService _loanService;
        public LoanController(ILoanService loanService)
        {
            _loanService = loanService;
        }
        [HttpGet("{loanId}", Name = "GetLoan")]
        public async Task<IActionResult> GetLoanAsync(int loanId, CancellationToken cancellationToken)
        {
            var loanSummary = await _loanService.GetLoanAsync(loanId, cancellationToken);
            if (loanSummary is null)
            {
                return NotFound();
            }

            return Ok(loanSummary);
        }

        [HttpPost]
        public async Task<ActionResult<LoanResponseDto>> CreateLoan(CreateLoanRequestDto request, CancellationToken cancellationToken)
        {
            var loan = await _loanService.CreateLoanAsync(request, cancellationToken);
            // return CreatedAtAction(nameof(GetLoanAsync),new {loanId = loan.LoanId }, loan);
            //return StatusCode(StatusCodes.Status201Created, loan);
            return CreatedAtRoute("GetLoan", new { loanId = loan.LoanId },
        loan);
        }
    }
}
