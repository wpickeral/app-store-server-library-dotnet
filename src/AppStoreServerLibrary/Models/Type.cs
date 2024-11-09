namespace AppStoreServerLibrary.Models;

/// <summary>
/// The type of in-app purchase products you can offer in your app.
/// <para>
/// <see cref=" https://developer.apple.com/documentation/appstoreserverapi/type"/>
/// </para>
/// </summary>
public static class Type
{
    public const string AUTO_RENEWABLE_SUBSCRIPTION = "Auto-Renewable Subscription";
    public const string NON_CONSUMABLE = "Non-Consumable";
    public const string CONSUMABLE = "Consumable";
    public const string NON_RENEWING_SUBSCRIPTION = "Non-Renewing Subscription";
}
