using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

public class StatusResponse
{

    /// <summary>
    /// The server environment that the notification applies to, either sandbox or production.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreservernotifications/environment"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("environment")]
    public string? Environment { get; set; }

    /// <summary>
    /// The unique identifier the App Store uses to identify the app.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/storekit/apptransaction/3954436-appid"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("appAppleId")]
    public int? AppAppleId { get; set; }

    /// <summary>
    /// The bundle identifier that the app transaction applies to.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/storekit/apptransaction/3954439-bundleid"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("bundleId")]
    public string? BundleId { get; set; }

    /// <summary>
    /// An array of information for auto-renewable subscriptions, including App Store-signed transaction information and App Store-signed renewal information.
    /// </summary>
    [JsonPropertyName("data")]
    public SubscriptionGroupIdentifierItem[]? Data { get; set; }
}
