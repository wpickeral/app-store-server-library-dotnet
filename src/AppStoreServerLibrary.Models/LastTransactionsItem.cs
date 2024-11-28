using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// The most recent App Store-signed transaction information and App Store-signed renewal information for an auto-renewable subscription.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreserverapi/lasttransactionsitem"/>
/// </para>
/// </summary>
public class LastTransactionsItem
{
    /// <summary>
    /// The status of the auto-renewable subscription.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/status"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public Status? Status { get; set; }

    /// <summary>
    /// The original transaction identifier of a purchase. 
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/originaltransactionid"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("originalTransactionId")]
    public string? OriginalTransactionId { get; set; }

    /// <summary>
    /// Transaction information signed by the App Store, in JSON Web Signature (JWS) format.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/jwstransaction"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("signedTransactionInfo")]
    public string? SignedTransactionInfo { get; set; }

    /// <summary>
    /// Subscription renewal information, signed by the App Store, in JSON Web Signature (JWS) format.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/jwsrenewalinfo"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("signedRenewalInfo")]
    public string? SignedRenewalInfo { get; set; }
}
