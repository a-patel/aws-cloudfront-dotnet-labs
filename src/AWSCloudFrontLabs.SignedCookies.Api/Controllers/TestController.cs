#region Imports
using AWSCloudFrontLabs.SignedCookies.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
#endregion

namespace AWSCloudFrontLabs.SignedCookies.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IAwsCloudFrontService _awsCloudFrontService;
        private readonly ILogger<TestController> _logger;

        public TestController(IAwsCloudFrontService awsCloudFrontService, ILogger<TestController> logger)
        {
            _awsCloudFrontService = awsCloudFrontService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var cookies = _awsCloudFrontService.GetSignedCookies();

            return Ok(cookies);
        }
    }
}
