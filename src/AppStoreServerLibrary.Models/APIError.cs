namespace AppStoreServerLibrary.Models;


/// <summary>
/// Error codes that App Store Server API responses return.
/// </summary>
public enum APIError
{
    /// <summary>
    /// An error that indicates an invalid request.
    /// </summary>
    GeneralBadRequest = 4000000,

    /// <summary>
    /// An error that indicates an invalid app identifier.
    /// </summary>
    InvalidAppIdentifier = 4000002,

    /// <summary>
    /// An error that indicates an invalid request revision.
    /// </summary>
    InvalidRequestRevision = 4000005,

    /// <summary>
    /// An error that indicates an invalid transaction identifier.
    /// </summary>
    InvalidTransactionId = 4000006,

    /// <summary>
    /// An error that indicates an invalid original transaction identifier.
    /// </summary>
    InvalidOriginalTransactionId = 4000008,

    /// <summary>
    /// An error that indicates an invalid extend-by-days value.
    /// </summary>
    InvalidExtendByDays = 4000009,

    /// <summary>
    /// An error that indicates an invalid reason code.
    /// </summary>
    InvalidExtendReasonCode = 4000010,

    /// <summary>
    /// An error that indicates an invalid request identifier.
    /// </summary>
    InvalidRequestIdentifier = 4000011,

    /// <summary>
    /// An error that indicates that the start date is earlier than the earliest allowed date.
    /// </summary>
    StartDateTooFarInPast = 4000012,

    /// <summary>
    /// An error that indicates that the end date precedes the start date, or the two dates are equal.
    /// </summary>
    StartDateAfterEndDate = 4000013,

    /// <summary>
    /// An error that indicates the pagination token is invalid.
    /// </summary>
    InvalidPaginationToken = 4000014,

    /// <summary>
    /// An error that indicates the start date is invalid.
    /// </summary>
    InvalidStartDate = 4000015,

    /// <summary>
    /// An error that indicates the end date is invalid.
    /// </summary>
    InvalidEndDate = 4000016,

    /// <summary>
    /// An error that indicates the pagination token expired.
    /// </summary>
    PaginationTokenExpired = 4000017,

    /// <summary>
    /// An error that indicates the notification type or subtype is invalid.
    /// </summary>
    InvalidNotificationType = 4000018,

    /// <summary>
    /// An error that indicates the request is invalid because it has too many constraints applied.
    /// </summary>
    MultipleFiltersSupplied = 4000019,

    /// <summary>
    /// An error that indicates the test notification token is invalid.
    /// </summary>
    InvalidTestNotificationToken = 4000020,

    /// <summary>
    /// An error that indicates an invalid sort parameter.
    /// </summary>
    InvalidSort = 4000021,

    /// <summary>
    /// An error that indicates an invalid product type parameter.
    /// </summary>
    InvalidProductType = 4000022,

    /// <summary>
    /// An error that indicates the product ID parameter is invalid.
    /// </summary>
    InvalidProductId = 4000023,

    /// <summary>
    /// An error that indicates an invalid subscription group identifier.
    /// </summary>
    InvalidSubscriptionGroupIdentifier = 4000024,

    /// <summary>
    /// An error that indicates the query parameter exclude-revoked is invalid.
    /// </summary>
    InvalidExcludeRevoked = 4000025,

    /// <summary>
    /// An error that indicates an invalid in-app ownership type parameter.
    /// </summary>
    InvalidInAppOwnershipType = 4000026,

    /// <summary>
    /// An error that indicates a required storefront country code is empty.
    /// </summary>
    InvalidEmptyStorefrontCountryCodeList = 4000027,

    /// <summary>
    /// An error that indicates a storefront code is invalid.
    /// </summary>
    InvalidStorefrontCountryCode = 4000028,

    /// <summary>
    /// An error that indicates the revoked parameter contains an invalid value.
    /// </summary>
    InvalidRevoked = 4000030,

    /// <summary>
    /// An error that indicates the status parameter is invalid.
    /// </summary>
    InvalidStatus = 4000031,

    /// <summary>
    /// An error that indicates the value of the account tenure field is invalid.
    /// </summary>
    InvalidAccountTenure = 4000032,

    /// <summary>
    /// An error that indicates the value of the app account token field is invalid.
    /// </summary>
    InvalidAppAccountToken = 4000033,

    /// <summary>
    /// An error that indicates the value of the consumption status field is invalid.
    /// </summary>
    InvalidConsumptionStatus = 4000034,

    /// <summary>
    /// An error that indicates the customer consented field is invalid or doesn’t indicate that the customer consented.
    /// </summary>
    InvalidCustomerConsented = 4000035,

    /// <summary>
    /// An error that indicates the value in the delivery status field is invalid.
    /// </summary>
    InvalidDeliveryStatus = 4000036,

    /// <summary>
    /// An error that indicates the value in the lifetime dollars purchased field is invalid.
    /// </summary>
    InvalidLifetimeDollarsPurchased = 4000037,

    /// <summary>
    /// An error that indicates the value in the lifetime dollars refunded field is invalid.
    /// </summary>
    InvalidLifetimeDollarsRefunded = 4000038,

    /// <summary>
    /// An error that indicates the value in the platform field is invalid.
    /// </summary>
    InvalidPlatform = 4000039,

    /// <summary>
    /// An error that indicates the value in the playtime field is invalid.
    /// </summary>
    InvalidPlayTime = 4000040,

    /// <summary>
    /// An error that indicates the value in the sample content provided field is invalid.
    /// </summary>
    InvalidSampleContentProvided = 4000041,

    /// <summary>
    /// An error that indicates the value in the user status field is invalid.
    /// </summary>
    InvalidUserStatus = 4000042,

    /// <summary>
    /// An error that indicates the transaction identifier doesn’t represent a consumable in-app purchase.
    /// </summary>
    InvalidTransactionNotConsumable = 4000043,

    /// <summary>
    /// An error that indicates the transaction identifier represents an unsupported in-app purchase type.
    /// </summary>
    InvalidTransactionTypeNotSupported = 4000047,

    /// <summary>
    /// An error that indicates the subscription doesn't qualify for a renewal-date extension due to its subscription state.
    /// </summary>
    SubscriptionExtensionIneligible = 4030004,

    /// <summary>
    /// An error that indicates the subscription doesn’t qualify for a renewal-date extension because it has already received the maximum extensions.
    /// </summary>
    SubscriptionMaxExtension = 4030005,

    /// <summary>
    /// An error that indicates a subscription isn't directly eligible for a renewal date extension because the user obtained it through Family Sharing.
    /// </summary>
    FamilySharedSubscriptionExtensionIneligible = 4030007,

    /// <summary>
    /// An error that indicates the App Store account wasn’t found.
    /// </summary>
    AccountNotFound = 4040001,

    /// <summary>
    /// An error response that indicates the App Store account wasn’t found, but you can try again.
    /// </summary>
    AccountNotFoundRetryable = 4040002,

    /// <summary>
    /// An error that indicates the app wasn’t found.
    /// </summary>
    AppNotFound = 4040003,

    /// <summary>
    /// An error response that indicates the app wasn’t found, but you can try again.
    /// </summary>
    AppNotFoundRetryable = 4040004,

    /// <summary>
    /// An error that indicates an original transaction identifier wasn't found.
    /// </summary>
    OriginalTransactionIdNotFound = 4040005,

    /// <summary>
    /// An error response that indicates the original transaction identifier wasn’t found, but you can try again.
    /// </summary>
    OriginalTransactionIdNotFoundRetryable = 4040006,

    /// <summary>
    /// An error that indicates that the App Store server couldn’t find a notifications URL for your app in this environment.
    /// </summary>
    ServerNotificationUrlNotFound = 4040007,

    /// <summary>
    /// An error that indicates that the test notification token is expired or the test notification status isn’t available.
    /// </summary>
    TestNotificationNotFound = 4040008,

    /// <summary>
    /// An error that indicates the server didn't find a subscription-renewal-date extension request for the request identifier and product identifier you provided.
    /// </summary>
    StatusRequestNotFound = 4040009,

    /// <summary>
    /// An error that indicates a transaction identifier wasn't found.
    /// </summary>
    TransactionIdNotFound = 4040010,

    /// <summary>
    /// An error that indicates that the request exceeded the rate limit.
    /// </summary>
    RateLimitExceeded = 4290000,

    /// <summary>
    /// An error that indicates a general internal error.
    /// </summary>
    GeneralInternal = 5000000,

    /// <summary>
    /// An error response that indicates an unknown error occurred, but you can try again.
    /// </summary>
    GeneralInternalRetryable = 5000001
}
