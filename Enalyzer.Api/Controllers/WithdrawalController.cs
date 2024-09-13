using Enalyzer.Api.Core.Queries.WithdrawalQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enalyzer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WithdrawalController : ControllerBase
    {
        private readonly ILogger<WithdrawalController> _logger;
        private readonly IMediator _mediator;

        public WithdrawalController(ILogger<WithdrawalController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost(Name = "GetWithdrawalDetail")]
        public async Task<ActionResult<IEnumerable<WithdrawalQueryResponse>>> Post([FromBody] WithdrawalQuery withdrawalQuery)
        {
            var response = await _mediator.Send(withdrawalQuery);

            if (response == null || !response.Any())
                return NoContent();

            return Ok(response);
        }
    }
}
