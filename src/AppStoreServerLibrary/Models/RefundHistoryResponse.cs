using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

public class RefundHistoryResponse
{

    /// <summary>
    /// A list of up to 20 JWS transactions, or an empty array if the customer hasn&#39;t received any refunds in your app. The transactions are sorted in ascending order by revocationDate.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/jwstransaction"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("signedTransactions")]
    public string[]? SignedTransactions { get; set; }

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
}
