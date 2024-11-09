namespace AppStoreServerLibrary.Models;

/// <summary>
/// The code that represents the reason for the subscription-renewal-date extension.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreserverapi/extendreasoncode"/>
/// </para>
/// </summary>
public enum ExtendReasonCode
{
    Undeclared = 0,
    CustomerSatisfaction = 1,
    Other = 2,
    ServiceIssueOrOutage = 3
}
