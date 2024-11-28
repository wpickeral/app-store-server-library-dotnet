namespace AppStoreServerLibrary.Models;

/// <summary>
/// The type that describes the in-app purchase or external purchase event for which the App Store sends the version 2 notification.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreservernotifications/notificationtype"/>
/// </para>
/// </summary>
public static class NotificationTypeV2
{
    public readonly static string SUBSCRIBED = "SUBSCRIBED";
    public readonly static string DID_CHANGE_RENEWAL_PREF = "DID_CHANGE_RENEWAL_PREF";
    public readonly static string DID_CHANGE_RENEWAL_STATUS = "DID_CHANGE_RENEWAL_STATUS";
    public readonly static string OFFER_REDEEMED = "OFFER_REDEEMED";
    public readonly static string DID_RENEW = "DID_RENEW";
    public readonly static string EXPIRED = "EXPIRED";
    public readonly static string DID_FAIL_TO_RENEW = "DID_FAIL_TO_RENEW";
    public readonly static string GRACE_PERIOD_EXPIRED = "GRACE_PERIOD_EXPIRED";
    public readonly static string PRICE_INCREASE = "PRICE_INCREASE";
    public readonly static string REFUND = "REFUND";
    public readonly static string REFUND_DECLINED = "REFUND_DECLINED";
    public readonly static string RENEWAL_EXTENDED = "RENEWAL_EXTENDED";
    public readonly static string REVOKE = "REVOKE";
    public readonly static string TEST = "TEST";
    public readonly static string RENEWAL_EXTENSION = "RENEWAL_EXTENSION";
    public readonly static string REFUND_REVERSED = "REFUND_REVERSED";
    public readonly static string EXTERNAL_PURCHASE_TOKEN = "EXTERNAL_PURCHASE_TOKEN";
    public readonly static string ONE_TIME_CHARGE = "ONE_TIME_CHARGE";
}
