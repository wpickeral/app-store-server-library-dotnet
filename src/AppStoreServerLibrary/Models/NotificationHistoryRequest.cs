using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// The request body for notification history.
/// </summary>
/// <remarks>
/// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/notificationhistoryrequest">NotificationHistoryRequest</a>
/// </remarks>
public class NotificationHistoryRequest
{
    /// <summary>
    /// The start date of the timespan for the requested App Store Server Notification history records. The startDate needs to precede the endDate. 
    /// Choose a startDate that’s within the past 180 days from the current date.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/startdate">startDate</a>
    /// </remarks>
    [JsonPropertyName("startDate")]
    public long? StartDate { get; set; }

    /// <summary>
    /// The end date of the timespan for the requested App Store Server Notification history records. 
    /// Choose an endDate that’s later than the startDate. If you choose an endDate in the future, the endpoint automatically uses the current date as the endDate.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/enddate">endDate</a>
    /// </remarks>
    [JsonPropertyName("endDate")]
    public long? EndDate { get; set; }

    /// <summary>
    /// A notification type. Provide this field to limit the notification history records to those with this one notification type. 
    /// For a list of notifications types, see notificationType. Include either the transactionId or the notificationType in your query, but not both.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/notificationtype">notificationType</a>
    /// </remarks>
    [JsonPropertyName("notificationType")]
    public string? NotificationType { get; set; }

    /// <summary>
    /// A notification subtype. Provide this field to limit the notification history records to those with this one notification subtype. 
    /// For a list of subtypes, see subtype. If you specify a notificationSubtype, you need to also specify its related notificationType.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/notificationsubtype">notificationSubtype</a>
    /// </remarks>
    [JsonPropertyName("notificationSubtype")]
    public string? NotificationSubtype { get; set; }

    /// <summary>
    /// The transaction identifier, which may be an original transaction identifier, of any transaction belonging to the customer. 
    /// Provide this field to limit the notification history request to this one customer. Include either the transactionId or the notificationType in your query, but not both.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/transactionid">transactionId</a>
    /// </remarks>
    [JsonPropertyName("transactionId")]
    public string? TransactionId { get; set; }

    /// <summary>
    /// A Boolean value you set to true to request only the notifications that haven’t reached your server successfully. 
    /// The response also includes notifications that the App Store server is currently retrying to send to your server.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/onlyfailures">onlyFailures</a>
    /// </remarks>
    [JsonPropertyName("onlyFailures")]
    public bool? OnlyFailures { get; set; }
}
