namespace AppStoreServerLibrary.Models;

/// <summary>
/// The reason for a refunded transaction.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreserverapi/revocationreason"/>
/// </para>
/// </summary>
public enum RevocationReason
{
    RefundedDueToIssue = 1,
    RefundedForOtherReason = 0
}
