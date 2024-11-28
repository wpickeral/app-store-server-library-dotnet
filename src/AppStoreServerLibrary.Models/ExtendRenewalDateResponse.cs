using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// A response that indicates whether an individual renewal-date extension succeeded, and related details.
/// </summary>
/// <remarks>
/// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/extendrenewaldateresponse">ExtendRenewalDateResponse</a>
/// </remarks>
public class ExtendRenewalDateResponse
{
    /// <summary>
    /// The original transaction identifier of a purchase.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/originaltransactionid">originalTransactionId</a>
    /// </remarks>
    [JsonPropertyName("originalTransactionId")]
    public string? OriginalTransactionId { get; set; }

    /// <summary>
    /// The unique identifier of subscription-purchase events across devices, including renewals.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/weborderlineitemid">webOrderLineItemId</a>
    /// </remarks>
    [JsonPropertyName("webOrderLineItemId")]
    public string? WebOrderLineItemId { get; set; }

    /// <summary>
    /// A Boolean value that indicates whether the subscription-renewal-date extension succeeded.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/success">success</a>
    /// </remarks>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// The new subscription expiration date for a subscription-renewal extension.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/effectivedate">effectiveDate</a>
    /// </remarks>
    [JsonPropertyName("effectiveDate")]
    public long? EffectiveDate { get; set; }
}
