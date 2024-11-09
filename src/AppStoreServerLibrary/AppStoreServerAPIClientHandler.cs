using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using Jose;

namespace AppStoreServerLibrary;

public class AppStoreServerAPIClientHandler : DelegatingHandler
{

    private readonly AppStoreServerAPIClientOptions _options;

    public AppStoreServerAPIClientHandler(IOptions<AppStoreServerAPIClientOptions> options)
    {
        _options = options.Value;
    }

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {

        request.Headers.Authorization = new AuthenticationHeaderValue(
        JwtBearerDefaults.AuthenticationScheme,
        GenerateJwtToken());

        var httpResponseMessage = await base.SendAsync(
            request,
            cancellationToken);

        httpResponseMessage.EnsureSuccessStatusCode();

        return httpResponseMessage;
    }

    private string GenerateJwtToken()
    {
        var header = new Dictionary<string, object>
        {
            { "alg", "ES256" },
            { "kid", _options.KeyId },
            { "typ", "JWT" }
        };

        var payoad = new Dictionary<string, object>
        {

            {"iss", _options.IssuerId},
            {"iat", DateTimeOffset.UtcNow.ToUnixTimeSeconds() },
            {"exp", DateTimeOffset.UtcNow.AddMinutes(5).ToUnixTimeSeconds()},
            {"aud", "appstoreconnect-v1" },
            {"bid", _options.BundleId }
        };

        CngKey key = CngKey.Import(Convert.FromBase64String(_options.SigningKey), CngKeyBlobFormat.Pkcs8PrivateBlob);

        var token = JWT.Encode(payoad, key, JwsAlgorithm.ES256, header);
        return token;
    }
}


