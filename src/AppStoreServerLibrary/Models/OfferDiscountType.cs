namespace AppStoreServerLibrary.Models;

/// <summary>
/// The payment mode you configure for an introductory offer, promotional offer, or offer code on an auto-renewable subscription.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreserverapi/offerdiscounttype"/>
/// </para>
/// </summary>
public static class OfferDiscountType
{
    public const string FREE_TRIAL = "FREE_TRIAL";
    public const string PAY_AS_YOU_GO = "PAY_AS_YOU_GO";
    public const string PAY_UP_FRONT = "PAY_UP_FRONT";
}


