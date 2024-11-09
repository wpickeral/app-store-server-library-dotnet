using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// Information for auto-renewable subscriptions, including signed transaction information and signed renewal information, for one subscription group.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreserverapi/subscriptiongroupidentifieritem"/>
/// </para>
/// </summary>
public class SubscriptionGroupIdentifierItem
{
    /// <summary>
    /// The identifier of the subscription group that the subscription belongs to.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/subscriptiongroupidentifier"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("subscriptionGroupIdentifier")]
    public string? SubscriptionGroupIdentifier { get; set; }

    /// <summary>
    ///  An array of the most recent App Store-signed transaction information and App Store-signed renewal information for all auto-renewable subscriptions in the subscription group.
    ///  <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/lasttransactionsitem"/> 
    /// </para>
    /// </summary>
    [JsonPropertyName("lastTransactions")]
    public LastTransactionsItem[]? LastTransactions { get; set; }
}



