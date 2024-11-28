using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// The App Store server notification history record, including the signed notification payload and the result of the server’s first send attempt.
/// </summary>
/// <remarks>
/// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/notificationhistoryresponseitem">notificationHistoryResponseItem</a>
/// </remarks>
public class NotificationHistoryResponseItem
{
    /// <summary>
    /// A cryptographically signed payload, in JSON Web Signature (JWS) format, containing the response body for a version 2 notification.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreservernotifications/signedpayload">signedPayload</a>
    /// </remarks>
    [JsonPropertyName("signedPayload")]
    public string? SignedPayload { get; set; }

    /// <summary>
    /// An array of information the App Store server records for its attempts to send a notification to your server. The maximum number of entries in the array is six.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/sendattemptitem">sendAttemptItem</a>
    /// </remarks>
    [JsonPropertyName("sendAttempts")]
    public List<SendAttemptItem>? SendAttempts { get; set; }
}
