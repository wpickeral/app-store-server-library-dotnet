using AppStoreServerLibrary;
using AppStoreServerLibrary.Models;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;

public enum VerificationStatus
{
    Ok,
    VerificationFailure,
    InvalidAppIdentifier,
    InvalidEnvironment,
    InvalidChainLength,
    InvalidCertificate,
    Failure
}

public class VerificationException : Exception
{
    public VerificationStatus Status { get; }
    public Exception Cause { get; }

    public VerificationException(VerificationStatus status, Exception cause = null)
        : base(cause?.Message)
    {
        Status = status;
        Cause = cause;
    }
}

public class SignedDataVerifier : ISignedDataVerifier
{
    private readonly List<X509Certificate2> rootCertificates;
    private readonly AppStoreServerAPIClientOptions _options;
    private readonly bool enableOnlineChecks;
    private readonly string bundleId;
    private readonly int? appAppleId;
    private readonly ILogger<SignedDataVerifier> _logger;
    private const string AppleJwksUrl = "https://appleid.apple.com/auth/keys";

    /// <summary>
    /// Initializes the SignedDataVerifier.
    /// </summary>
    /// <param name="appleRootCertificates">A list of DER-encoded root certificates.</param>
    /// <param name="enableOnlineChecks">Whether to enable revocation checking and check expiration using the current date.</param>
    /// <param name="environment">The App Store environment to target for checks.</param>
    /// <param name="bundleId">The app's bundle identifier.</param>
    /// <param name="appAppleId">The app's identifier, omitted in the sandbox environment.</param>
    /// <exception cref="ArgumentException">Thrown when appAppleId is required but not provided in production environment.</exception>
    public SignedDataVerifier(IOptions<AppStoreServerAPIClientOptions> options, ILogger<SignedDataVerifier> logger)
    {
        _options = options.Value;
        if (_options.Environment == Environment.PRODUCTION && appAppleId == null)
        {
            throw new ArgumentException("appAppleId is required when the environment is Production.");
        }

        _logger = logger;
    }


    public NotificationData ValidateAndDecodeNotificationV2(string signedPayload)
    {
        JWSRenewalInfoDecodedPayload? renewalInfo = null;
        JWSTransactionDecodedPayload? transactionInfo = null;

        if (signedPayload is null)
            throw new Exception("signedPayload is null");

        var result = GetVerifiedDecodedData<ResponseBodyV2DecodedPayload>(signedPayload);

        if (result is null || !result.IsValid)
            throw new Exception("The JWS for this request is not valid");

        ResponseBodyV2DecodedPayload? decodedPayload = result.DecodedData;

        if (!string.IsNullOrEmpty(decodedPayload?.Data?.SignedRenewalInfo))
        {
            renewalInfo = GetVerifiedDecodedData<JWSRenewalInfoDecodedPayload>(decodedPayload.Data.SignedRenewalInfo)?.DecodedData;
        }

        if (!string.IsNullOrEmpty(decodedPayload?.Data?.SignedTransactionInfo))
        {
            transactionInfo = GetVerifiedDecodedData<JWSTransactionDecodedPayload>(decodedPayload.Data.SignedTransactionInfo)?.DecodedData;
        }

        return new NotificationData()
        {
            SignedData = decodedPayload,
            RenewalData = renewalInfo,
            TransactionData = transactionInfo
        };
    }

    private VerifiedAndDecodedData<T>? GetVerifiedDecodedData<T>(string signedPayload)
    {
        if (string.IsNullOrEmpty(signedPayload))
        {
            throw new ArgumentException("Signed Payload is null");
        }

        var splitParts = signedPayload.Split("."); // header, payload, signature representation

        var valid = VerifyToken(signedPayload);

        var base64EncodedPayload = splitParts[1];
        var decodedPayloadBytes = WebEncoders.Base64UrlDecode(base64EncodedPayload);
        var decodedPayloadString = Encoding.UTF8.GetString(decodedPayloadBytes);
        var decodedPayload = JsonSerializer.Deserialize<T>(decodedPayloadString);

        return new VerifiedAndDecodedData<T>()
        {
            DecodedData = decodedPayload ?? default,
            IsValid = valid
        };
    }

    private bool VerifyToken(string token)
    {
        try
        {
            var header = JsonSerializer.Deserialize<JWSDecodedHeader>(Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(token.Split(".")[0])));

            if (header?.X5c is null || header.X5c.Length == 0)
                throw new KeyNotFoundException("Token header does not contain x5c");

            var handler = new JwtSecurityTokenHandler();
            handler.ReadToken(token);
            var securityToken = Validate(handler, token, header.X5c.First());

            return securityToken is not null;
        }
        catch (Exception e)
        {
            _logger.LogError("{Exception}", e);
            return false;
        }
    }

    private static SecurityToken? Validate(JwtSecurityTokenHandler tokenHandler, string jwtToken, string publicKey)
    {
        var certificateBytes = Base64UrlEncoder.DecodeBytes(publicKey);
        var certificate = new X509Certificate2(certificateBytes);
        var eCDsa = certificate.GetECDsaPublicKey();

        TokenValidationParameters tokenValidationParameters = new()
        {
            ValidateAudience = false,
            ValidateLifetime = false,
            ValidateIssuer = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new ECDsaSecurityKey(eCDsa)
        };

        tokenHandler.ValidateToken(jwtToken, tokenValidationParameters, out var securityToken);
        return securityToken;
    }

}
