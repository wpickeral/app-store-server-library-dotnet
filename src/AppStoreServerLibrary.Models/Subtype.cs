namespace AppStoreServerLibrary.Models;

/// <summary>
/// A string that provides details about select notification types in version 2.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreservernotifications/subtype"/>
/// </para>
/// </summary>
public static class Subtype
{
    public const string INITIAL_BUY = "INITIAL_BUY";
    public const string RESUBSCRIBE = "RESUBSCRIBE";
    public const string DOWNGRADE = "DOWNGRADE";
    public const string UPGRADE = "UPGRADE";
    public const string AUTO_RENEW_ENABLED = "AUTO_RENEW_ENABLED";
    public const string AUTO_RENEW_DISABLED = "AUTO_RENEW_DISABLED";
    public const string VOLUNTARY = "VOLUNTARY";
    public const string BILLING_RETRY = "BILLING_RETRY";
    public const string PRICE_INCREASE = "PRICE_INCREASE";
    public const string GRACE_PERIOD = "GRACE_PERIOD";
    public const string PENDING = "PENDING";
    public const string ACCEPTED = "ACCEPTED";
    public const string BILLING_RECOVERY = "BILLING_RECOVERY";
    public const string PRODUCT_NOT_FOR_SALE = "PRODUCT_NOT_FOR_SALE";
    public const string SUMMARY = "SUMMARY";
    public const string FAILURE = "FAILURE";
    public const string UNREPORTED = "UNREPORTED";
}

