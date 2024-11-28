using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

public class JWSRenewalInfoDecodedPayload : DecodedSignedData
{
    /// <summary>
    /// The reason the subscription expired.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/expirationintent">expirationIntent</a>
    /// </remarks>
    [JsonPropertyName("expirationIntent")]
    public ExpirationIntent? ExpirationIntent { get; set; }

    /// <summary>
    /// The original transaction identifier of a purchase.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/originaltransactionid">originalTransactionId</a>
    /// </remarks>
    [JsonPropertyName("originalTransactionId")]
    public string? OriginalTransactionId { get; set; }

    /// <summary>
    /// The product identifier of the product that will renew at the next billing period.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/autorenewproductid">autoRenewProductId</a>
    /// </remarks>
    [JsonPropertyName("autoRenewProductId")]
    public string? AutoRenewProductId { get; set; }

    /// <summary>
    /// The unique identifier for the product, that you create in App Store Connect.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/productid">productId</a>
    /// </remarks>
    [JsonPropertyName("productId")]
    public string? ProductId { get; set; }

    /// <summary>
    /// The renewal status of the auto-renewable subscription.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/autorenewstatus">autoRenewStatus</a>
    /// </remarks>
    [JsonPropertyName("autoRenewStatus")]
    public AutoRenewStatus? AutoRenewStatus { get; set; }

    /// <summary>
    /// A Boolean value that indicates whether the App Store is attempting to automatically renew an expired subscription.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/isinbillingretryperiod">isInBillingRetryPeriod</a>
    /// </remarks>
    [JsonPropertyName("isInBillingRetryPeriod")]
    public bool? IsInBillingRetryPeriod { get; set; }

    /// <summary>
    /// The status that indicates whether the auto-renewable subscription is subject to a price increase.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/priceincreasestatus">priceIncreaseStatus</a>
    /// </remarks>
    [JsonPropertyName("priceIncreaseStatus")]
    public PriceIncreaseStatus? PriceIncreaseStatus { get; set; }

    /// <summary>
    /// The time when the billing grace period for subscription renewals expires.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/graceperiodexpiresdate">gracePeriodExpiresDate</a>
    /// </remarks>
    [JsonPropertyName("gracePeriodExpiresDate")]
    public long? GracePeriodExpiresDate { get; set; }

    /// <summary>
    /// The type of the subscription offer.
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
    /// The earliest start date of a subscription in a series of auto-renewable subscription purchases that ignores all lapses of paid service shorter than 60 days.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/recentsubscriptionstartdate">recentSubscriptionStartDate</a>
    /// </remarks>
    [JsonPropertyName("recentSubscriptionStartDate")]
    public long? RecentSubscriptionStartDate { get; set; }

    /// <summary>
    /// The UNIX time, in milliseconds, when the most recent auto-renewable subscription purchase expires.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/renewaldate">renewalDate</a>
    /// </remarks>
    [JsonPropertyName("renewalDate")]
    public long? RenewalDate { get; set; }

    /// <summary>
    /// The currency code for the renewalPrice of the subscription.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/currency">currency</a>
    /// </remarks>
    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    /// <summary>
    /// The renewal price, in milliunits, of the auto-renewable subscription that renews at the next billing period.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/renewalprice">renewalPrice</a>
    /// </remarks>
    [JsonPropertyName("renewalPrice")]
    public long? RenewalPrice { get; set; }

    /// <summary>
    /// The payment mode of the discount offer.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/offerdiscounttype">offerDiscountType</a>
    /// </remarks>
    [JsonPropertyName("offerDiscountType")]
    public string? OfferDiscountType { get; set; }

    /// <summary>
    /// An array of win-back offer identifiers that a customer is eligible to redeem, which sorts the identifiers to present the better offers first.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/eligiblewinbackofferids">eligibleWinBackOfferIds</a>
    /// </remarks>
    [JsonPropertyName("eligibleWinBackOfferIds")]
    public string[]? EligibleWinBackOfferIds { get; set; }
}

