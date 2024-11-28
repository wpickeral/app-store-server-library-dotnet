using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// The app metadata and the signed renewal and transaction information.
/// <para>
/// See: <a href="https://developer.apple.com/documentation/appstoreservernotifications/data">data</a>
/// </para>
/// </summary>
public class Data
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
    public int? AppAppleId { get; set; }

    /// <summary>
    /// The bundle identifier of an app.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/bundleid"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("bundleId")]
    public string? BundleId { get; set; }

    /// <summary>
    /// The version of the build that identifies an iteration of the bundle.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreservernotifications/bundleversion"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("bundleVersion")]
    public string? BundleVersion { get; set; }

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

    /// <summary>
    /// The status of an auto-renewable subscription as of the signedDate in the responseBodyV2DecodedPayload.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreservernotifications/statu"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public Status? Status { get; set; }

    /// <summary>
    /// The reason the customer requested the refund.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreservernotifications/consumptionrequestreason"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("consumptionRequestReason")]
    public string? ConsumptionRequestReason { get; set; }
}
