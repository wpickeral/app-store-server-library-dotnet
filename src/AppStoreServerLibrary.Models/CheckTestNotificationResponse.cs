using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// A response that contains the contents of the test notification sent by the App Store server and the result from your server.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreserverapi/checktestnotificationresponse"/>
/// </para>
/// </summary>
public class CheckTestNotificationResponse
{
    /// <summary>
    /// A cryptographically signed payload, in JSON Web Signature (JWS) format, containing the response body for a version 2 notification.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreservernotifications/signedpayload "/>
    /// </para>
    /// </summary>
    [JsonPropertyName("signedPayload")]
    public string? SignedPayload { get; set; }

    /// <summary>
    /// An array of information the App Store server records for its attempts to send the TEST notification to your server. The array may contain a maximum of six sendAttemptItem objects.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/sendattemptitem"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("sendAttempts")]
    public SendAttemptItem[]? SendAttempts { get; set; }
}



