namespace AppStoreServerLibrary.Models;

/// <summary>
/// The relationship of the user with the family-shared purchase to which they have access.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreserverapi/inappownershiptype"/>
/// </para>
/// </summary>
public static class InAppOwnershipType
{
    public const string FAMILY_SHARED = "FAMILY_SHARED";
    public const string PURCHASED = "PURCHASED";
}
