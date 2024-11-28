namespace AppStoreServerLibrary.Models;

/// <summary>
/// The status of an auto-renewable subscription.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreserverapi/status"/>
/// </para>
/// </summary>
public enum Status
{
    Active = 1,
    Expired = 2,
    BillingRetry = 3,
    BillingGracePeriod = 4,
    Revoked = 5,
}
