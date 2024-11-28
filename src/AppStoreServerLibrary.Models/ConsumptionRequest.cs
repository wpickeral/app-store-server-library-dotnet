using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// The request body containing consumption information.
/// </summary>
/// <remarks>
/// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/consumptionrequest">ConsumptionRequest</a>
/// </remarks>
public class ConsumptionRequest
{
    /// <summary>
    /// A Boolean value that indicates whether the customer consented to provide consumption data to the App Store.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/customerconsented">customerConsented</a>
    /// </remarks>
    [JsonPropertyName("customerConsented")]
    public bool? CustomerConsented { get; set; }

    /// <summary>
    /// A value that indicates the extent to which the customer consumed the in-app purchase.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/consumptionstatus">consumptionStatus</a>
    /// </remarks>
    [JsonPropertyName("consumptionStatus")]
    public ConsumptionStatus ConsumptionStatus { get; set; }  // Can be either a ConsumptionStatus enum or a number

    /// <summary>
    /// A value that indicates the platform on which the customer consumed the in-app purchase.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/platform">platform</a>
    /// </remarks>
    [JsonPropertyName("platform")]
    public object Platform { get; set; }  // Can be either a Platform enum or a number

    /// <summary>
    /// A Boolean value that indicates whether you provided, prior to its purchase, a free sample or trial of the content, or information about its functionality.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/samplecontentprovided">sampleContentProvided</a>
    /// </remarks>
    [JsonPropertyName("sampleContentProvided")]
    public bool? SampleContentProvided { get; set; }

    /// <summary>
    /// A value that indicates whether the app successfully delivered an in-app purchase that works properly.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/deliverystatus">deliveryStatus</a>
    /// </remarks>
    [JsonPropertyName("deliveryStatus")]
    public object DeliveryStatus { get; set; }  // Can be either a DeliveryStatus enum or a number

    /// <summary>
    /// The UUID that an app optionally generates to map a customer’s in-app purchase with its resulting App Store transaction.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/appaccounttoken">appAccountToken</a>
    /// </remarks>
    [JsonPropertyName("appAccountToken")]
    public string AppAccountToken { get; set; }

    /// <summary>
    /// The age of the customer’s account.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/accounttenure">accountTenure</a>
    /// </remarks>
    [JsonPropertyName("accountTenure")]
    public object AccountTenure { get; set; }  // Can be either an AccountTenure enum or a number

    /// <summary>
    /// A value that indicates the amount of time that the customer used the app.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/consumptionrequest">ConsumptionRequest</a>
    /// </remarks>
    [JsonPropertyName("playTime")]
    public object PlayTime { get; set; }  // Can be either a PlayTime enum or a number

    /// <summary>
    /// A value that indicates the total amount, in USD, of refunds the customer has received, in your app, across all platforms.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/lifetimedollarsrefunded">lifetimeDollarsRefunded</a>
    /// </remarks>
    [JsonPropertyName("lifetimeDollarsRefunded")]
    public object LifetimeDollarsRefunded { get; set; }  // Can be either a LifetimeDollarsRefunded enum or a number

    /// <summary>
    /// A value that indicates the total amount, in USD, of in-app purchases the customer has made in your app, across all platforms.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/lifetimedollarspurchased">lifetimeDollarsPurchased</a>
    /// </remarks>
    [JsonPropertyName("lifetimeDollarsPurchased")]
    public object LifetimeDollarsPurchased { get; set; }  // Can be either a LifetimeDollarsPurchased enum or a number

    /// <summary>
    /// The status of the customer’s account.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/userstatus">userStatus</a>
    /// </remarks>
    [JsonPropertyName("userStatus")]
    public object UserStatus { get; set; }  // Can be either a UserStatus enum or a number

    /// <summary>
    /// A value that indicates your preference, based on your operational logic, as to whether Apple should grant the refund.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/refundpreference">refundPreference</a>
    /// </remarks>
    [JsonPropertyName("refundPreference")]
    public object RefundPreference { get; set; }  // Can be either a RefundPreference enum or a number
}
