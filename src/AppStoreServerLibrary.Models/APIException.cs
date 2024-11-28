namespace AppStoreServerLibrary.Models;


public class APIException : Exception
{
    public string StatusCode { get; }
    public string? ErrorCode { get; }
    public string? ErrorMessage { get; }

    public APIException(string statusCode, string? errorCode = null, string? errorMessage = null)
        : base(errorMessage ?? "API error")
    {
        StatusCode = statusCode;
        ErrorCode = errorCode;
        ErrorMessage = errorMessage;
    }
}
