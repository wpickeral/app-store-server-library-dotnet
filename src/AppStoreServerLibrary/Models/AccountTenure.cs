namespace AppStoreServerLibrary.Models;

/// <summary>
/// The age of the customer's account.
/// <para>
/// <seealso cref="https://developer.apple.com/documentation/appstoreserverapi/accounttenure"/>
/// </para>
/// </summary>
public enum AccountTenure
{
    Undeclared = 0,
    ZeroToThreeDays = 1,
    ThreeDaysToTenDays = 2,
    TenDaysToThirtyDays = 3,
    ThirtyDaysToNinetyDays = 4,
    NinetyDaysToOneHundredEightyDays = 5,
    OneHundredEightyDaysToThreeHundredSixtyFiveDays = 6,
    GreaterThanThreeHundredSixtyFiveDays = 7,
}
