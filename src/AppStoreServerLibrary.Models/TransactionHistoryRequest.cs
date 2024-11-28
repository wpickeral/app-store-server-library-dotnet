using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

public class TransactionHistoryRequest
{

    /// <summary>
    ///  An optional start date of the timespan for the transaction history records you’re requesting. The startDate must precede the endDate if you specify both dates. To be included in results, the transaction’s purchaseDate must be equal to or greater than the startDate.
    ///  <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/startdate"/> 
    /// </para>
    /// </summary>
    [JsonPropertyName("startDate")]
    public int? StartDate { get; set; }

    /// <summary>
    /// An optional end date of the timespan for the transaction history records you’re requesting. Choose an endDate that’s later than the startDate if you specify both dates. Using an endDate in the future is valid. To be included in results, the transaction’s purchaseDate must be less than the endDate.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/enddate"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("endDate")]
    public int? EndDate { get; set; }

    /// <summary>
    /// An optional filter that indicates the product identifier to include in the transaction history. Your query may specify more than one productID.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/productid"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("productIds")]
    public string[]? ProductIds { get; set; }

    /// <summary>
    /// An optional filter that indicates the product type to include in the transaction history. Your query may specify more than one productType.
    /// </summary>
    [JsonPropertyName("productType")]
    public string? ProductType { get; set; }

    /// <summary>
    /// An optional sort order for the transaction history records. The response sorts the transaction records by their recently modified date. The default value is ASCENDING, so you receive the oldest records first.
    /// </summary>
    [JsonPropertyName("sort")]
    public string? Sort { get; set; }

    /// <summary>
    /// An optional filter that indicates the subscription group identifier to include in the transaction history. Your query may specify more than one subscriptionGroupIdentifier.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/subscriptiongroupidentifier"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("subscriptionGroupIdentifiers")]
    public string[]? SubscriptionGroupIdentifiers { get; set; }

    /// <summary>
    /// An optional filter that limits the transaction history by the in-app ownership type.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/inappownershiptype"/> 
    /// </para>
    /// </summary>
    [JsonPropertyName("inAppOwnershipType")]
    public string? InAppOwnershipType { get; set; }

    /// <summary>
    ///  An optional Boolean value that indicates whether the response includes only revoked transactions when the value is true, or contains only nonrevoked transactions when the value is false. By default, the request doesn't include this parameter.
    /// </summary>
    [JsonPropertyName("revoked")]
    public bool? Revoked { get; set; }
}
