using Microsoft.AspNetCore.Mvc;

namespace Enalyzer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WithdrawalController : ControllerBase
    {
        private readonly ILogger<WithdrawalController> _logger;

        public WithdrawalController(ILogger<WithdrawalController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWithdrawalDetail")]
        public IEnumerable<WeatherForecast> Get(FromBodyAttribute)
        {

        }
    }
}
