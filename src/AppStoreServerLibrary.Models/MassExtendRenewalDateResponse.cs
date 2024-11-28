using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
///  A response that indicates the server successfully received the subscription-renewal-date extension request.
/// </summary>
/// <remarks>
/// See: https://developer.apple.com/documentation/appstoreserverapi/massextendrenewaldateresponse
/// </remarks>
public class MassExtendRenewalDateResponse
{

    /// <summary>
    /// A string that contains a unique identifier you provide to track each subscription-renewal-date extension request.
    /// </summary>
    /// <remarks>
    /// See: https://developer.apple.com/documentation/appstoreserverapi/requestidentifier
    /// </remarks>
    [JsonPropertyName("requestIdentifier")]
    public string? RequestIdentifier { get; set; }
}
