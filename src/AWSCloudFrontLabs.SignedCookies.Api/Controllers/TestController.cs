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
        #region Members

        private readonly IAwsCloudFrontService _awsCloudFrontService;
        private readonly ILogger<TestController> _logger;

        #endregion

        #region Ctor

        public TestController(IAwsCloudFrontService awsCloudFrontService, ILogger<TestController> logger)
        {
            _awsCloudFrontService = awsCloudFrontService;
            _logger = logger;
        }

        #endregion

        #region Methods

        [HttpGet]
        public IActionResult Get()
        {
            var cookies = _awsCloudFrontService.GetSignedCookies();

            return Ok(cookies);
        }

        #endregion
    }
}
