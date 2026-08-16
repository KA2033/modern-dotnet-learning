using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModernDotNet.LoanManagement.Api.Services;

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
        [HttpGet("{loanId}")]
        public async Task<IActionResult> GetLoanSummaryAsync(int loanId, CancellationToken cancellationToken)
        {
            var loanSummary = await _loanService.GetLoanSummaryAsync(loanId, cancellationToken);
            if (loanSummary is null)
            {
                return NotFound();
            }

            return Ok(loanSummary);
        }
    }
}
