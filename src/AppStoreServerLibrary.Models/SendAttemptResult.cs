namespace AppStoreServerLibrary.Models;

/// <summary>
///  The success or error information the App Store server records when it attempts to send an App Store server notification to your server.
///  <para>
/// <see cref="https://developer.apple.com/documentation/appstoreserverapi/sendattemptresult"/> 
/// </para>
/// </summary>
public static class SendAttemptResult
{
    public const string SUCCESS = "SUCCESS";
    public const string TIMED_OUT = "TIMED_OUT";
    public const string TLS_ISSUE = "TLS_ISSUE";
    public const string CIRCULAR_REDIRECT = "CIRCULAR_REDIRECT";
    public const string NO_RESPONSE = "NO_RESPONSE";
    public const string SOCKET_ISSUE = "SOCKET_ISSUE";
    public const string UNSUPPORTED_CHARSET = "UNSUPPORTED_CHARSET";
    public const string INVALID_RESPONSE = "INVALID_RESPONSE";
    public const string PREMATURE_CLOSE = "PREMATURE_CLOSE";
    public const string UNSUCCESSFUL_HTTP_RESPONSE_CODE = "UNSUCCESSFUL_HTTP_RESPONSE_CODE";
    public const string OTHER = "OTHER";
}
