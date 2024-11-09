using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// Represents the response that indicates the status of a request to extend the subscription renewal date for active subscribers.
/// </summary>
public class MassExtendRenewalDateStatusResponse
{
    /// <summary>
    /// A string that contains a unique identifier you provide to track each subscription-renewal-date extension request.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/requestidentifier">requestIdentifier</a>
    /// </remarks>
    [JsonPropertyName("requestIdentifier")]
    public string RequestIdentifier { get; set; }

    /// <summary>
    /// A Boolean value that indicates whether the App Store completed the request to extend a subscription renewal date to active subscribers.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/complete">complete</a>
    /// </remarks>
    [JsonPropertyName("complete")]
    public bool? Complete { get; set; }

    /// <summary>
    /// The UNIX time, in milliseconds, that the App Store completes a request to extend a subscription renewal date for eligible subscribers.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/completedate">completeDate</a>
    /// </remarks>
    [JsonPropertyName("completeDate")]
    public long? CompleteDate { get; set; }

    /// <summary>
    /// The count of subscriptions that successfully receive a subscription-renewal-date extension.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/succeededcount">succeededCount</a>
    /// </remarks>
    [JsonPropertyName("succeededCount")]
    public int? SucceededCount { get; set; }

    /// <summary>
    /// The count of subscriptions that fail to receive a subscription-renewal-date extension.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/failedcount">failedCount</a>
    /// </remarks>
    [JsonPropertyName("failedCount")]
    public int? FailedCount { get; set; }
}

