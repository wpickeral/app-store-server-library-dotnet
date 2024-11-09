using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// The AppTransaction class to represent the customer’s purchase of the app
/// </summary>
public class AppTransaction
{
    /// <summary>
    /// The version external identifier of the app
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/storekit/apptransaction/3954438-appversionid"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("receiptType")]
    public string? ReceiptType { get; set; }

    /// <summary>
    /// The unique identifier the App Store uses to identify the app.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/storekit/apptransaction/3954436-appid"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("appAppleId")]
    public int? AppAppleId { get; set; }

    /// <summary>
    /// The bundle identifier that the app transaction applies to.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/storekit/apptransaction/3954439-bundleid"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("bundleId")]
    public string? BundleId { get; set; }

    /// <summary>
    /// The app version that the app transaction applies to.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/storekit/apptransaction/3954437-appversion"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("applicationVersion")]
    public string? ApplicationVersion { get; set; }

    /// <summary>
    /// The version external identifier of the app
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/storekit/apptransaction/3954438-appversionid "/>
    /// </para>
    /// </summary>
    [JsonPropertyName("versionExternalIdentifier")]
    public int? VersionExternalIdentifier { get; set; }

    /// <summary>
    /// The date that the App Store signed the JWS app transaction.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/storekit/apptransaction/3954449-signeddate"/> 
    /// </para>
    /// </summary>
    [JsonPropertyName("receiptCreationDate")]
    public int? ReceiptCreationDate { get; set; }

    /// <summary>
    /// The date the user originally purchased the app from the App Store.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/storekit/apptransaction/3954448-originalpurchasedate"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("originalPurchaseDate")]
    public int? OriginalPurchaseDate { get; set; }

    /// <summary>
    /// The app version that the user originally purchased from the App Store.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/storekit/apptransaction/3954447-originalappversion"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("originalApplicationVersion")]
    public string? OriginalApplicationVersion { get; set; }

    /// <summary>
    /// The Base64 device verification value to use to verify whether the app transaction belongs to the device.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/storekit/apptransaction/3954441-deviceverification "/>
    /// </para>
    /// </summary>
    [JsonPropertyName("deviceVerification")]
    public string? DeviceVerification { get; set; }

    /// <summary>
    /// The UUID used to compute the device verification value.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/storekit/apptransaction/3954442-deviceverificationnonce"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("deviceVerificationNouce")]
    public string? DeviceVerificationNonce { get; set; }

    /// <summary>
    /// The date the customer placed an order for the app before it’s available in the App Store.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/storekit/apptransaction/4013175-preorderdate"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("preorderDate")]
    public int? PreorderDate { get; set; }
}
