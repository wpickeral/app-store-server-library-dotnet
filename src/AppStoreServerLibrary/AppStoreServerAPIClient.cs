using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using AppStoreServerLibrary.Models;
using Microsoft.Extensions.Options;

namespace AppStoreServerLibrary;

public class AppStoreServerAPIClient : IAppStoreServerAPIClient
{

    private const string PRODUCTION_URL = "https://api.storekit.itunes.apple.com";
    private const string SANDBOX_URL = "https://api.storekit-sandbox.itunes.apple.com";
    private const string LOCAL_TESTING_URL = "https://local-testing-base-url";
    private const string USER_AGENT = "app-store-server-library-dotnet/1.0.0";

    private readonly string _urlBase = Environment.SANDBOX;
    private readonly HttpClient _httpClient;

    /// <summary>
    /// Create an App Store Server API client
    /// </summary>
    /// <exception cref="Exception"></exception>
    public AppStoreServerAPIClient(IOptions<AppStoreServerAPIClientOptions> options, HttpClient httpClient)
    {
        _urlBase = options.Value.Environment switch
        {
            Environment.XCODE => throw new Exception("Xcode is not a supported environment for an AppStoreServerAPIClient"),
            Environment.PRODUCTION => PRODUCTION_URL,
            Environment.LOCAL_TESTING => LOCAL_TESTING_URL,
            Environment.SANDBOX => SANDBOX_URL,
            _ => throw new Exception("Environment must be Production, LocalTesting or Sandbox"),
        };

        _httpClient = httpClient;
        _httpClient.DefaultRequestHeaders.Add("User-Agent", USER_AGENT);
        _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        _httpClient.BaseAddress = new Uri(_urlBase);
    }

    /// <summary>
    /// Uses a subscription’s product identifier to extend the renewal date for all of its eligible active subscribers.
    /// </summary>
    /// <param name="massExtendRenewalDateRequest">The request body for extending a subscription renewal date for all of its active subscribers.</param>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/extend_subscription_renewal_dates_for_all_active_subscribers">Extend Subscription Renewal Dates for All Active Subscribers</a>
    /// </remarks>
    /// <returns>A response that indicates the server successfully received the subscription-renewal-date extension request.</returns>
    /// <exception cref="APIException">If a response was returned indicating the request could not be processed</exception>
    public async Task<MassExtendRenewalDateResponse?> ExtendRenewalDateForAllActiveSubscribers(MassExtendRenewalDateRequest massExtendRenewalDateRequest)
    {
        var response = await _httpClient.PostAsJsonAsync("/inApps/v1/subscriptions/extend/mass", massExtendRenewalDateRequest);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<MassExtendRenewalDateResponse?>();
        }

        throw await ApiException(response);
    }


    /// <summary>
    /// Extends the renewal date of a customer’s active subscription using the original transaction identifier.
    /// </summary>
    /// <param name="originalTransactionId">The original transaction identifier of the subscription receiving a renewal date extension.</param>
    /// <param name="extendRenewalDateRequest">The request body containing subscription-renewal-extension data.</param>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/extend_a_subscription_renewal_date">Extend a Subscription Renewal Date</a>
    /// </remarks>
    /// <returns>A response that indicates whether an individual renewal-date extension succeeded, and related details.</returns>
    public async Task<ExtendRenewalDateResponse?> ExtendSubscriptionRenewalDate(string originalTransactionId, ExtendRenewalDateRequest extendRenewalDateRequest)
    {
        var response = await _httpClient.PutAsJsonAsync($"/inApps/v1/subscriptions/extend/{originalTransactionId}", extendRenewalDateRequest);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<ExtendRenewalDateResponse?>();
        }

        throw await ApiException(response);
    }

    /// <summary>
    /// Get the statuses for all of a customer’s auto-renewable subscriptions in your app.
    /// </summary>
    /// <param name="transactionId">The identifier of a transaction that belongs to the customer, and which may be an original transaction identifier.</param>
    /// <param name="status">An optional filter that indicates the status of subscriptions to include in the response. Your query may specify more than one status query parameter.</param>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/extend_a_subscription_renewal_date">Extend a Subscription Renewal Date</a>
    /// </remarks>
    /// <returns>A response that contains status information for all of a customer’s auto-renewable subscriptions in your app.</returns>
    /// <exception cref="APIException">If a response was returned indicating the request could not be processed</exception>
    public async Task<StatusResponse?> GetAllSubscriptionStatuses(string transactionId, Status[]? status = null)
    {
        var queryParams = new Dictionary<string, string>();
        if (status != null)
        {
            queryParams["status"] = string.Join(",", status);
        }

        var path = AppendQueryParamsToPath($"/inApps/v1/subscriptions/{transactionId}", queryParams);

        var response = await _httpClient.GetAsync(path);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<StatusResponse>();
        }

        throw await ApiException(response);
    }

    /// <summary>
    /// Get a paginated list of all of a customer’s refunded in-app purchases for your app.
    /// </summary>
    /// <param name="transactionId">The identifier of a transaction that belongs to the customer, and which may be an original transaction identifier.</param>
    /// <param name="revision">A token you provide to get the next set of up to 20 transactions. All responses include a revision token. Use the revision token from the previous RefundHistoryResponse.</param>
    /// <returns>A response that contains status information for all of a customer’s auto-renewable subscriptions in your app.</returns>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/get_refund_history">Get Refund History</a> 
    /// </remarks>
    /// <returns>A response that contains status information for all of a customer’s auto-renewable subscriptions in your app.</returns>
    /// <exception cref="APIException">If a response was returned indicating the request could not be processed</exception>
    public async Task<RefundHistoryResponse?> GetRefundHistory(string transactionId, string? revision = null)
    {
        var queryParams = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(revision))
        {
            queryParams["revision"] = revision;
        }

        var path = AppendQueryParamsToPath($"/inApps/v2/refund/lookup/{transactionId}", queryParams);

        var response = await _httpClient.GetAsync(path);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<RefundHistoryResponse>();
        }

        throw await ApiException(response);
    }

    /// <summary>
    /// Checks whether a renewal date extension request completed, and provides the final count of successful or failed extensions.
    /// </summary>
    /// <param name="requestIdentifier">The UUID that represents your request to the Extend Subscription Renewal Dates for All Active Subscribers endpoint.</param>
    /// <param name="productId">The product identifier of the auto-renewable subscription that you request a renewal-date extension for.</param>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/get_status_of_subscription_renewal_date_extensions">Get Status of Subscription Renewal Date Extensions</a> 
    /// </remarks>
    /// <returns>A response that indicates the current status of a request to extend the subscription renewal date to all eligible subscribers.</returns>
    /// <exception cref="APIException">If a response was returned indicating the request could not be processed</exception>
    public async Task<MassExtendRenewalDateStatusResponse?> GetStatusOfSubscriptionRenewalDateExtensions(string requestIdentifier, string productId)
    {

        var response = await _httpClient.GetAsync($"/inApps/v1/subscriptions/extend/mass/{productId}/{requestIdentifier}");

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<MassExtendRenewalDateStatusResponse>();
        }

        throw await ApiException(response);
    }
 
    public async Task<CheckTestNotificationResponse?> GetTestNotificationStatus(string testNotificationToken)
    {

        var response = await _httpClient.GetAsync($"/inApps/v1/notifications/test/{testNotificationToken}");

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<CheckTestNotificationResponse>();
        }

        throw await ApiException(response);
    }

    public async Task<NotificationHistoryResponse?> GetNotificationHistory(string paginationToken, NotificationHistoryRequest notificationHistoryRequest)
    {
        var queryParams = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(paginationToken))
        {
            queryParams["paginationToken"] = paginationToken;
        }

        var path = $"/inApps/v1/notifications/history";

        AppendQueryParamsToPath(path, queryParams);

        var response = await _httpClient.PostAsJsonAsync(path, notificationHistoryRequest);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<NotificationHistoryResponse>();
        }

        throw await ApiException(response);
    }

    public async Task<HistoryResponse?> GetTransactionHistory(string transactionId, string revision, TransactionHistoryRequest transactionHistoryRequest, string version = GetTransactionHistoryVersion.V2)
    {
        var queryParams = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(revision))
        {
            queryParams["revision"] = revision;
        }

        // Additional filters from transactionHistoryRequest
        if (transactionHistoryRequest.StartDate != null)
        {
            queryParams["startDate"] = transactionHistoryRequest.StartDate.ToString()!;
        }

        if (transactionHistoryRequest.EndDate != null)
        {
            queryParams["endDate"] = transactionHistoryRequest.EndDate.ToString()!;
        }

        var path = $"/inApps/{version}/history/{transactionId}";

        AppendQueryParamsToPath(path, queryParams);

        var response = await _httpClient.GetAsync(path);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<HistoryResponse>();
        }

        throw await ApiException(response);
    }

    public async Task<TransactionInfoResponse?> GetTransactionInfo(string transactionId)
    {
        var response = await _httpClient.GetAsync($"/inApps/v1/transactions/{transactionId}");

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<TransactionInfoResponse>();
        }

        throw await ApiException(response);
    }

    public async Task<OrderLookupResponse?> LookUpOrderId(string orderId)
    {
        var response = await _httpClient.GetAsync($"/inApps/v1/lookup/{orderId}");

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<OrderLookupResponse>();
        }

        throw await ApiException(response);
    }

    /// <summary>
    /// Ask App Store Server Notifications to send a test notification to your server.
    /// </summary>
    /// <remarks>
    /// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/request_a_test_notification">Request a Test Notification</a>
    /// </remarks>
    /// <returns>A response that contains the test notification token.</returns>
    /// <exception cref="APIException">If a response was returned indicating the request could not be processed</exception>
    public async Task<SendTestNotificationResponse?> RequestTestNotification()
    {
        var response = await _httpClient.PostAsync("/inApps/v1/notifications/test", null);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<SendTestNotificationResponse>();
        }

        throw await ApiException(response);
    }

    public async Task SendConsumptionData(string transactionId, ConsumptionRequest consumptionRequest)
    {
        var response = await _httpClient.PutAsJsonAsync($"/inApps/v1/transactions/consumption/{transactionId}", consumptionRequest);

        if (response.IsSuccessStatusCode)
        {
            return;
        }

        throw await ApiException(response);
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="response">The http response message</param>
    /// <returns></returns>
    /// <exception cref="APIException">If a response was returned indicating the request could not be processed</exception>
    private static async Task<APIException> ApiException(HttpResponseMessage response)
    {
        try
        {
            var responseBody = await response.Content.ReadAsStringAsync();

            var errorResponse = JsonSerializer.Deserialize<Dictionary<string, string>>(responseBody);



            if (errorResponse != null && errorResponse.ContainsKey("errorCode"))
            {
                var errorCode = errorResponse["errorCode"];
                var errorMessage = errorResponse["errorMessage"];
                return new APIException(response.StatusCode.ToString(), errorCode, errorMessage);
            }


            return new APIException(response.StatusCode.ToString());
        }
        catch (Exception ex)
        {
            // If there was an error parsing the response, throw an APIException
            if (ex is APIException apiEx)
            {
                return apiEx;
            }

            return new APIException(response.StatusCode.ToString());
        }
    }

    private static string AppendQueryParamsToPath(string path, Dictionary<string, List<string>> queryParameters)
    {
        var queryString = new List<string>();
        foreach (var queryParam in queryParameters)
        {
            foreach (var queryVal in queryParam.Value)
            {
                queryString.Add($"{queryParam.Key}={Uri.EscapeDataString(queryVal)}");
            }
        }

        string queryParamString = string.Join("&", queryString);
        if (!string.IsNullOrEmpty(queryParamString))
        {
            path = $"{path}?{queryParamString}";
        }

        return path;
    }

    private static string AppendQueryParamsToPath(string path, Dictionary<string, string> queryParams)
    {
        var queryString = new StringBuilder(path);
        if (queryParams.Count > 0)
        {
            queryString.Append('?');
            foreach (var param in queryParams)
            {
                queryString.Append($"{param.Key}={Uri.EscapeDataString(param.Value)}&");
            }
            queryString.Length--;  // Remove the trailing '&'
        }

        return queryString.ToString();
    }
}

