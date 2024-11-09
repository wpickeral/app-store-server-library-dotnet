using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// The success or error information and the date the App Store server records when it attempts to send a server notification to your server.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreserverapi/sendattemptitem"/>
/// </para>
/// </summary>
public class SendAttemptItem
{
    /// <summary>
    /// The date the App Store server attempts to send a notification.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/attemptdate"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("attemptDate")]
    public int? AttemptDate { get; set; }

    /// <summary>
    /// The success or error information the App Store server records when it attempts to send an App Store server notification to your server.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/sendattemptresult"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("sendAttemptResult")]
    public string? SendAttemptResult { get; set; }
}
