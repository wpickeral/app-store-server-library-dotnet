using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// A response that includes the order lookup status and an array of signed transactions for the in-app purchases in the order.
/// </summary>
/// <remarks>
/// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/orderlookupresponse">OrderLookupResponse</a>
/// </remarks>
public class OrderLookupResponse
{
    /// <summary>
    /// The status that indicates whether the order ID is valid.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/orderlookupstatus">OrderLookupStatus</a>
    /// </remarks>
    [JsonPropertyName("status")]
    public Status Status { get; set; }

    /// <summary>
    /// An array of in-app purchase transactions that are part of the order, signed by Apple, in JSON Web Signature format.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/jwstransaction">JWSTransaction</a>
    /// </remarks>
    [JsonPropertyName("signedTransactions")]
    public List<string>? SignedTransactions { get; set; }
}
