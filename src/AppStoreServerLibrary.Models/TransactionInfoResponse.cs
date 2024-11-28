using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// A response that contains signed transaction information for a single transaction.
/// <para>
/// https://developer.apple.com/documentation/appstoreservernotifications/transactioninforesponse 
/// </para>
/// </summary>
public class TransactionInfoResponse
{
    /// <summary>
    /// A customer’s in-app purchase transaction, signed by Apple, in JSON Web Signature (JWS) format.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/jwstransaction"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("signedTransactionInfo")]
    public string? SignedTransactionInfo { get; set; }
}
