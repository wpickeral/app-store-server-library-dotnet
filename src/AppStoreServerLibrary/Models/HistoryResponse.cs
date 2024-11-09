using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// A response that contains the customer’s transaction history for an app.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreserverapi/historyresponse"/>
/// </para>
/// </summary>
public class HistoryResponse
{
    /// <summary>
    /// A token you use in a query to request the next set of transactions for the customer.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/revision"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>
    /// A Boolean value indicating whether the App Store has more transaction data.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/hasmore"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("hasMore")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// The bundle identifier of an app.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/bundleid"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("bundleId")]
    public string? BundleId { get; set; }

    /// <summary>
    /// The unique identifier of an app in the App Store.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreservernotifications/appappleid"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("appAppleId")]
    public int? AppAppleId { get; set; }

    /// <summary>
    /// The server environment in which you’re making the request, whether sandbox or production.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/environment"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("environment")]
    public string? Environment { get; set; }

    /// <summary>
    /// An array of in-app purchase transactions for the customer, signed by Apple, in JSON Web Signature format.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/jwstransaction"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("signedTransactions")]
    public string[]? SignedTransactions { get; set; }
}
