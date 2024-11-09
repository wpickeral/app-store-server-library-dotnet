namespace AppStoreServerLibrary.Models;

/// <summary>
/// The status of a customer’s account within your app.
/// <para>
/// <see cref="https://developer.apple.com/documentation/appstoreserverapi/userstatus"/>
/// </para>
/// </summary>
public enum UserStatus
{
    Undeclared = 0,
    Active = 1,
    Suspended = 2,
    Terminated = 3,
    LimitedAccess = 4
}
