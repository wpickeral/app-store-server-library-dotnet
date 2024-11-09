using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// A response that contains the test notification token.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreserverapi/sendtestnotificationresponse"/>
/// </para>
/// </summary>
public class SendTestNotificationResponse
{
    /// <summary>
    /// A unique identifier for a notification test that the App Store server sends to your server.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/testnotificationtoken"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("testNotificationToken")]
    public string? TestNotificationToken { get; set; }
}
