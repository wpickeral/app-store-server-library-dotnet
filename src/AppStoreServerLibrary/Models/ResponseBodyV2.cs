using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// The response body the App Store sends in a version 2 server notification.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreservernotifications/responsebodyv2"/>
/// </para>
/// </summary>
public class ResponseBodyV2
{
    /// <summary>
    /// A cryptographically signed payload, in JSON Web Signature (JWS) format, containing the response body for a version 2 notification.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreservernotifications/signedpayload "/>
    /// </para>
    /// </summary>
    [JsonPropertyName("signedPayload")]
    public string? SignedPayload { get; set; }
}
