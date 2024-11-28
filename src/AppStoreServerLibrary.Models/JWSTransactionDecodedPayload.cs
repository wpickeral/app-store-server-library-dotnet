using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

public class JWSTransactionDecodedPayload : DecodedSignedData
{
    /// <summary>
    /// The original transaction identifier of a purchase.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/originaltransactionid">originalTransactionId</a>
    /// </remarks>
    [JsonPropertyName("originalTransactionId")]
    public string? OriginalTransactionId { get; set; }

    /// <summary>
    /// The unique identifier for a transaction such as an in-app purchase, restored in-app purchase, or subscription renewal.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/transactionid">transactionId</a>
    /// </remarks>
    [JsonPropertyName("transactionId")]
    public string? TransactionId { get; set; }

    /// <summary>
    /// The unique identifier of subscription-purchase events across devices, including renewals.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/weborderlineitemid">webOrderLineItemId</a>
    /// </remarks>
    [JsonPropertyName("webOrderLineItemId")]
    public string? WebOrderLineItemId { get; set; }

    /// <summary>
    /// The bundle identifier of an app.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/bundleid">bundleId</a>
    /// </remarks>
    [JsonPropertyName("bundleId")]
    public string? BundleId { get; set; }

    /// <summary>
    /// The unique identifier for the product, that you create in App Store Connect.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/productid">productId</a>
    /// </remarks>
    [JsonPropertyName("productId")]
    public string? ProductId { get; set; }

    /// <summary>
    /// The identifier of the subscription group that the subscription belongs to.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/subscriptiongroupidentifier">subscriptionGroupIdentifier</a>
    /// </remarks>
    [JsonPropertyName("subscriptionGroupIdentifier")]
    public string? SubscriptionGroupIdentifier { get; set; }

    /// <summary>
    /// The time that the App Store charged the user’s account for an in-app purchase, a restored in-app purchase, a subscription, or a subscription renewal after a lapse.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/purchasedate">purchaseDate</a>
    /// </remarks>
    [JsonPropertyName("purchaseDate")]
    public long? PurchaseDate { get; set; }

    /// <summary>
    /// The purchase date of the transaction associated with the original transaction identifier.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/originalpurchasedate">originalPurchaseDate</a>
    /// </remarks>
    [JsonPropertyName("originalPurchaseDate")]
    public long? OriginalPurchaseDate { get; set; }

    /// <summary>
    /// The UNIX time, in milliseconds, an auto-renewable subscription expires or renews.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/expiresdate">expiresDate</a>
    /// </remarks>
    [JsonPropertyName("expiresDate")]
    public long? ExpiresDate { get; set; }

    /// <summary>
    /// The number of consumable products purchased.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/quantity">quantity</a>
    /// </remarks>
    [JsonPropertyName("quantity")]
    public int? Quantity { get; set; }

    /// <summary>
    /// The type of the in-app purchase.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/type">type</a>
    /// </remarks>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// The UUID that an app optionally generates to map a customer’s in-app purchase with its resulting App Store transaction.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/appaccounttoken">appAccountToken</a>
    /// </remarks>
    [JsonPropertyName("appAccountToken")]
    public string? AppAccountToken { get; set; }

    /// <summary>
    /// A string that describes whether the transaction was purchased by the user, or is available to them through Family Sharing.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/inappownershiptype">inAppOwnershipType</a>
    /// </remarks>
    [JsonPropertyName("inAppOwnershipType")]
    public string? InAppOwnershipType { get; set; }

    /// <summary>
    /// The UNIX time, in milliseconds, that the App Store signed the JSON Web Signature data.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/signeddate">signedDate</a>
    /// </remarks>
    [JsonPropertyName("signedDate")]
    public long? SignedDate { get; set; }

    /// <summary>
    /// The reason that the App Store refunded the transaction or revoked it from family sharing.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/revocationreason">revocationReason</a>
    /// </remarks>
    [JsonPropertyName("revocationReason")]
    public RevocationReason? RevocationReason { get; set; }

    /// <summary>
    /// The UNIX time, in milliseconds, that Apple Support refunded a transaction.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/revocationdate">revocationDate</a>
    /// </remarks>
    [JsonPropertyName("revocationDate")]
    public long? RevocationDate { get; set; }

    /// <summary>
    /// The Boolean value that indicates whether the user upgraded to another subscription.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/isupgraded">isUpgraded</a>
    /// </remarks>
    [JsonPropertyName("isUpgraded")]
    public bool? IsUpgraded { get; set; }

    /// <summary>
    /// A value that represents the promotional offer type.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/offertype">offerType</a>
    /// </remarks>
    [JsonPropertyName("offerType")]
    public OfferType? OfferType { get; set; }

    /// <summary>
    /// The identifier that contains the promo code or the promotional offer identifier.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/offeridentifier">offerIdentifier</a>
    /// </remarks>
    [JsonPropertyName("offerIdentifier")]
    public string? OfferIdentifier { get; set; }

    /// <summary>
    /// The server environment, either sandbox or production.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/environment">environment</a>
    /// </remarks>
    [JsonPropertyName("environment")]
    public string? Environment { get; set; }

    /// <summary>
    /// The three-letter code that represents the country or region associated with the App Store storefront for the purchase.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/storefront">storefront</a>
    /// </remarks>
    [JsonPropertyName("storefront")]
    public string? Storefront { get; set; }

    /// <summary>
    /// An Apple-defined value that uniquely identifies the App Store storefront associated with the purchase.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/storefrontid">storefrontId</a>
    /// </remarks>
    [JsonPropertyName("storefrontId")]
    public string? StorefrontId { get; set; }

    /// <summary>
    /// The reason for the purchase transaction, which indicates whether it’s a customer’s purchase or a renewal for an auto-renewable subscription that the system initiates.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/transactionreason">transactionReason</a>
    /// </remarks>
    [JsonPropertyName("transactionReason")]
    public string? TransactionReason { get; set; }

    /// <summary>
    /// The three-letter ISO 4217 currency code for the price of the product.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/currency">currency</a>
    /// </remarks>
    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    /// <summary>
    /// The price, in milliunits, of the in-app purchase or subscription offer that you configured in App Store Connect.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/price">price</a>
    /// </remarks>
    [JsonPropertyName("price")]
    public decimal? Price { get; set; }

    /// <summary>
    /// The payment mode you configure for an introductory offer, promotional offer, or offer code on an auto-renewable subscription.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/offerdiscounttype">offerDiscountType</a>
    /// </remarks>
    [JsonPropertyName("offerDiscountType")]
    public string? OfferDiscountType { get; set; }
}


