using System.ComponentModel;
using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// A decoded payload containing the version 2 notification data.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreservernotifications/responsebodyv2decodedpayload"/>
/// </para>
/// </summary>
public class ResponseBodyV2DecodedPayload : DecodedSignedData
{

    /// <summary>
    /// The in-app purchase event for which the App Store sends this version 2 notification.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreservernotifications/notificationtype"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("notificationType")]
    public string? NotificationType { get; set; }

    /// <summary>
    /// Additional information that identifies the notification event. The subtype field is present only for specific version 2 notifications.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreservernotifications/subtype"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("subtype")]
    public string? Subtype { get; set; }


    /// <summary>
    /// A unique identifier for the notification.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreservernotifications/notificationuuid"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("notificationUUID")]
    public string? NotificationUUID { get; set; }

    /// <summary>
    /// The object that contains the app metadata and signed renewal and transaction information.
    /// The data, summary, and externalPurchaseToken fields are mutually exclusive.The payload contains only one of these fields.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreservernotifications/data"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("data")]
    public Data? Data { get; set; }

    /// <summary>
    /// This field appears when the notificationType is EXTERNAL_PURCHASE_TOKEN.
    /// The data, summary, and externalPurchaseToken fields are mutually exclusive.The payload contains only one of these fields.
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreservernotifications/externalpurchasetoken"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("summary")]
    public Summary? Summary { get; set; }

}
