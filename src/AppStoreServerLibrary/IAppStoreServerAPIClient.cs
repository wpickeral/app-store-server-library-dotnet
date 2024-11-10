using AppStoreServerLibrary.Models;

namespace AppStoreServerLibrary;
public interface IAppStoreServerAPIClient
{
    Task<MassExtendRenewalDateResponse?> ExtendRenewalDateForAllActiveSubscribers(MassExtendRenewalDateRequest massExtendRenewalDateRequest);
    Task<ExtendRenewalDateResponse?> ExtendSubscriptionRenewalDate(string originalTransactionId, ExtendRenewalDateRequest extendRenewalDateRequest);
    Task<StatusResponse?> GetAllSubscriptionStatuses(string transactionId, Status[]? status = null);
    Task<NotificationHistoryResponse?> GetNotificationHistory(string paginationToken, NotificationHistoryRequest notificationHistoryRequest);
    Task<RefundHistoryResponse?> GetRefundHistory(string transactionId, string? revision = null);
    Task<MassExtendRenewalDateStatusResponse?> GetStatusOfSubscriptionRenewalDateExtensions(string requestIdentifier, string productId);

    /// <summary>
    /// Check the status of the test App Store server notification sent to your server.
    /// </summary>
    /// <param name="testNotificationToken">The test notification token received from the Request a Test Notification endpoint</param>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/get_test_notification_status">Get Test Notification Status</a> 
    /// </remarks>
    /// <returns>A response that contains the contents of the test notification sent by the App Store server and the result from your server.</returns>
    /// <exception cref="APIException">If a response was returned indicating the request could not be processed</exception>
    Task<CheckTestNotificationResponse?> GetTestNotificationStatus(string testNotificationToken);
    Task<HistoryResponse?> GetTransactionHistory(string transactionId, string revision, TransactionHistoryRequest transactionHistoryRequest, string version = "v2");
    Task<TransactionInfoResponse?> GetTransactionInfo(string transactionId);
    Task<OrderLookupResponse?> LookUpOrderId(string orderId);

    /// <summary>
    /// Ask App Store Server Notifications to send a test notification to your server.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/request_a_test_notification">Request a Test Notification</a>
    /// </remarks>
    /// <returns>A response that contains the test notification token.</returns>
    /// <exception cref="APIException">If a response was returned indicating the request could not be processed</exception>
    Task<SendTestNotificationResponse?> RequestTestNotification();
    Task SendConsumptionData(string transactionId, ConsumptionRequest consumptionRequest);
}