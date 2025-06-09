using Microsoft.AspNetCore.Mvc;

namespace IR.API.Controllers
{
    public class GrammarHelpController : Controller
    {
        private readonly ILogger<GrammarHelpController>? _logger;
        private IConfiguration? _configuration;
        public GrammarHelpController(ILogger<GrammarHelpController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }
        [HttpGet("version")]
        public string Version()
        {
            return _configuration["VERSION"];
        }
    }
}
