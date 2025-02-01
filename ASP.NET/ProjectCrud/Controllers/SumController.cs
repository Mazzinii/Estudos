using Microsoft.AspNetCore.Mvc;

namespace ProjectCrud.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SumController : ControllerBase
    {

        private readonly ILogger<SumController> _logger;

        public SumController(ILogger<SumController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Sum")]
        public int GetSum(int number1, int number2)
        {
            _logger.LogInformation($"Soma realizada {number1} + {number2}");
            return number1 + number2;
        }
        
        [HttpGet("Multiply")]
        public int GetMultiply(int number1, int number2)
        {
            _logger.LogInformation($"Multiplicação realizada {number1} * {number2}");
            return number1 * number2;
        }
        
    }
}
