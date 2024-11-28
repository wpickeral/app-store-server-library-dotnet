using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// The payload data for a subscription-renewal-date extension notification.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreservernotifications/summary"/>
/// </para>
/// </summary>
public class Summary
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
    /// The unique identifier of an app in the App Store.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreservernotifications/appappleid"/> 
    /// </para>
    /// </summary>
    [JsonPropertyName("appAppleId")]
    public string? AppAppleId { get; set; }

    /// <summary>
    /// The bundle identifier of an app.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/bundleid"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("bundleId")]
    public string? BundleId { get; set; }

    /// <summary>
    /// The unique identifier for the product, that you create in App Store Connect.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/productid"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("productId")]
    public string? ProductId { get; set; }

    /// <summary>
    /// A string that contains a unique identifier you provide to track each subscription-renewal-date extension request.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/requestidentifier"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("requestIdentifier")]
    public string? RequestIdentifier { get; set; }

    /// <summary>
    /// A list of storefront country codes you provide to limit the storefronts for a subscription-renewal-date extension.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/storefrontcountrycodes"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("storefrontCountryCodes")]
    public string[]? StorefrontCountryCodes { get; set; }

    /// <summary>
    /// The count of subscriptions that successfully receive a subscription-renewal-date extension.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/succeededcount"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("succeededCount")]
    public int? SuccessedCount { get; set; }

    /// <summary>
    /// The count of subscriptions that fail to receive a subscription-renewal-date extension.
    /// <para>
    /// <see cref=" https://developer.apple.com/documentation/appstoreserverapi/failedcount"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("failedCount")]
    public int? FailedCount { get; set; }
}
