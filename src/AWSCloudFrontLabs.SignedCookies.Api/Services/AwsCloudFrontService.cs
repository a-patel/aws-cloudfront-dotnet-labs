#region Imports
using Amazon.CloudFront;
using AWSCloudFrontLabs.SignedCookies.Api.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.IO;
#endregion

namespace AWSCloudFrontLabs.SignedCookies.Api.Services
{
    public class AwsCloudFrontService : IAwsCloudFrontService
    {
        #region Members

        private readonly CloudFrontOptions _cloudFrontOptions;
        private readonly IHostEnvironment _hostEnvironment;

        #endregion

        #region Ctor

        public AwsCloudFrontService(IOptions<CloudFrontOptions> options, IHostEnvironment hostEnvironment)
        {
            _cloudFrontOptions = options.Value;
            _hostEnvironment = hostEnvironment;
        }

        #endregion


        #region Methods

        public CookiesForCustomPolicy GetSignedCookies()
        {
            var privateKeyFilePath = Path.Combine(_hostEnvironment.ContentRootPath, "Configuration", _cloudFrontOptions.PrivateKeyFileName);
            var privateKeyFileTextReader = File.OpenText(privateKeyFilePath);

            var cookieSigner = AmazonCloudFrontCookieSigner.GetCookiesForCustomPolicy(_cloudFrontOptions.ResourceUrlOrPath,
                privateKeyFileTextReader,
                _cloudFrontOptions.KeyPairId, 
                DateTime.Now.AddSeconds(_cloudFrontOptions.ExpireDuration), 
                DateTime.Now.AddDays(-1),
                "0.0.0.0/0");

            return cookieSigner;
        }

        #endregion
    }
}
