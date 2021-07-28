using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSCloudFrontLabs.SignedCookies.Api.Configuration
{
    public class CloudFrontOptions
    {
        /// <summary>
        /// The URL or path for resource within a distribution.
        /// </summary>
        public string ResourceUrlOrPath { get; set; }

        /// <summary>
        /// The key pair id corresponding to the private key file given.
        /// </summary>
        public string KeyPairId { get; set; }

        /// <summary>
        /// Your private key file. RSA private key (.pem) are supported.
        /// under `Configuration` folder
        /// </summary>
        public string PrivateKeyFileName { get; set; }

        /// <summary>
        /// The expiration duration till which content can be accessed using the generated cookies.
        /// in seconds.
        /// </summary>
        public int ExpireDuration { get; set; }
    }
}
