namespace AppStoreServerLibrary.Models;

/// <summary>
/// The status that indicates whether an auto-renewable subscription is subject to a price increase.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreserverapi/priceincreasestatus"/>
/// </para>
/// </summary>
public enum PriceIncreaseStatus
{
    CustomerHasNotResponded = 0,
    CustomerConsentedOrWasNotifiedWithoutNeedingConsent = 1,
}
