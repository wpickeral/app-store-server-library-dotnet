namespace AppStoreServerLibrary.Models;

/// <summary>
/// A value that indicates whether the app successfully delivered an in-app purchase that works properly.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreserverapi/deliverystatus"/>
/// </para>
/// </summary>
public enum DeliveryStatus
{
    DeliveredAnWorkingProperly = 0,
    DidNotDeliverDueToQualityIssue = 1,
    DeliveredWrongItem = 2,
    DidNotDeliverDueToServerOutage = 3,
    DidNotDeliverDueToInGameCurrencyChange = 4,
    DidNotDeliverForOtherReason = 5,
}
