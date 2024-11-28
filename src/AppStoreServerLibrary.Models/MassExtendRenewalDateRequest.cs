using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// The request body that contains subscription-renewal-extension data to apply for all eligible active subscribers.
/// </summary>
/// <remarks>
/// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/massextendrenewaldaterequest">MassExtendRenewalDateRequest</a>
/// </remarks>
public class MassExtendRenewalDateRequest
{
    /// <summary>
    /// The number of days to extend the subscription renewal date.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/extendbydays">extendByDays</a>
    /// Maximum: 90
    /// </remarks>
    [JsonPropertyName("extendByDays")]
    public int? ExtendByDays { get; set; }

    /// <summary>
    /// The reason code for the subscription-renewal-date extension.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/extendreasoncode">extendReasonCode</a>
    /// </remarks>
    [JsonPropertyName("extendReasonCode")]
    public ExtendReasonCode? ExtendReasonCode { get; set; }

    /// <summary>
    /// A string that contains a unique identifier you provide to track each subscription-renewal-date extension request.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/requestidentifier">requestIdentifier</a>
    /// </remarks>
    [JsonPropertyName("requestIdentifier")]
    public string? RequestIdentifier { get; set; }

    /// <summary>
    /// A list of storefront country codes you provide to limit the storefronts for a subscription-renewal-date extension.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/storefrontcountrycodes">storefrontCountryCodes</a>
    /// </remarks>
    [JsonPropertyName("storefrontCountryCodes")]
    public string[] StorefrontCountryCodes { get; set; }

    /// <summary>
    /// The unique identifier for the product, that you create in App Store Connect.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/productid">productId</a>
    /// </remarks>
    [JsonPropertyName("productId")]
    public string? ProductId { get; set; }
}
