using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSCloudFrontLabs.SignedCookies.Api.Configuration
{
    public class CloudFrontOptions
    {
        public string CloudFrontUrl { get; set; }

        public string KeyPairId { get; set; }

        public string PrivateKey { get; set; }

        public string ExpireDuration { get; set; }
    }
}
