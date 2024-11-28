namespace AppStoreServerLibrary.Models;

/// <summary>
/// The cause of a purchase transaction, which indicates whether it’s a customer’s purchase or a renewal for an auto-renewable subscription that the system initiates.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreserverapi/transactionreason"/>
/// </para>
/// </summary>
public static class TransactionReason
{
    public const string PURCHASE = "PURCHASE";
    public const string RENEWAL = "RENEWAL";
}
