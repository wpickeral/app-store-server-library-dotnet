using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// A response that contains the App Store Server Notifications history for your app.
/// </summary>
/// <remarks>
/// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/notificationhistoryresponse">NotificationHistoryResponse</a>
/// </remarks>
public class NotificationHistoryResponse
{
    /// <summary>
    /// A pagination token that you return to the endpoint on a subsequent call to receive the next set of results.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/paginationtoken">paginationToken</a>
    /// </remarks>
    [JsonPropertyName("paginationToken")]
    public string? PaginationToken { get; set; }

    /// <summary>
    /// A Boolean value indicating whether the App Store has more transaction data.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/hasmore">hasMore</a>
    /// </remarks>
    [JsonPropertyName("hasMore")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// An array of App Store server notification history records.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/notificationhistoryresponseitem">notificationHistoryResponseItem</a>
    /// </remarks>
    [JsonPropertyName("notificationHistory")]
    public List<NotificationHistoryResponseItem>? NotificationHistory { get; set; }
}
