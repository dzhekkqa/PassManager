using Microsoft.AspNetCore.Mvc;

namespace PassManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController: ControllerBase
    {
        private ILogger<AuthController> _logger;

        private IConfiguration _config;
        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetData()
        {
            _logger.LogInformation("Gotcha!");
            return Ok();
        }
    }
}
