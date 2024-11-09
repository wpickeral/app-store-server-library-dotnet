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
    Task<CheckTestNotificationResponse?> GetTestNotificationStatus(string testNotificationToken);
    Task<HistoryResponse?> GetTransactionHistory(string transactionId, string revision, TransactionHistoryRequest transactionHistoryRequest, string version = "v2");
    Task<TransactionInfoResponse?> GetTransactionInfo(string transactionId);
    Task<OrderLookupResponse?> LookUpOrderId(string orderId);
    Task<SendTestNotificationResponse?> RequestTestNotification();
    Task SendConsumptionData(string transactionId, ConsumptionRequest consumptionRequest);
}