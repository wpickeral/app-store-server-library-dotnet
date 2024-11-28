using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// The request body that contains subscription-renewal-extension data for an individual subscription.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreserverapi/extendrenewaldaterequest"/>
/// </para>
/// </summary>
public class ExtendRenewalDateRequest
{

    /// <summary>
    /// The number of days to extend the subscription renewal date.
    /// <para>
    /// maximum: 90
    /// </para>
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/extendbydays"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("extendByDays")]
    public int? ExtendByDays { get; set; }

    /// <summary>
    /// The reason code for the subscription date extension
    /// <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/extendreasoncode"/>
    /// </para>
    /// </summary>
    [JsonPropertyName("extendReasonCode")]
    public ExtendReasonCode? ExtendReasonCode { get; set; }

    /// <summary>
    ///  A string that contains a unique identifier you provide to track each subscription-renewal-date extension request.
    ///  <para>
    /// <see cref="https://developer.apple.com/documentation/appstoreserverapi/requestidentifier"/> 
    /// </para>
    /// </summary>
    [JsonPropertyName("requestIdentifier")]
    public string? RequestIdentifier { get; set; }
}
