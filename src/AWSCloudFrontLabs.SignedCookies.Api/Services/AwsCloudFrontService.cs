#region Imports
using Amazon.CloudFront;
using AWSCloudFrontLabs.SignedCookies.Api.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
#endregion

namespace AWSCloudFrontLabs.SignedCookies.Api.Services
{
    public class AwsCloudFrontService
    {
        #region Members

        private readonly CloudFrontOptions _cloudFrontOptions;
        private readonly IAmazonCloudFront _cloudFrontClient;

        #endregion

        #region Ctor

        public AwsCloudFrontService(IOptions<CloudFrontOptions> options)
        {
            _cloudFrontOptions = options.Value;
        }

        #endregion


        #region Methods

        public void GetSignedCookies()
        {
            var signer = _cloudFrontClient.(keyPairId, privateKey);
        }

        #endregion
    }
}
