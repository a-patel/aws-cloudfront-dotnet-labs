using Amazon.CloudFront;

namespace AWSCloudFrontLabs.SignedCookies.Api.Services
{
    public interface IAwsCloudFrontService
    {
        CookiesForCustomPolicy GetSignedCookies();
    }
}