namespace AppStoreServerLibrary.Models;

/// <summary>
/// The reason an auto-renewable subscription expired.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreserverapi/expirationintent"/>
/// </para>
/// </summary>
public enum ExpirationIntent
{
    CustomerCancelled = 1,
    BillingError = 2,
    CustomerDidNotConsentToPriceIncrease = 3,
    ProductNotAvailable = 4,
    Other = 5
}
