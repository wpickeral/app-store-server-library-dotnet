using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

public class DecodedSignedData
{
    /// <summary>
    /// The UNIX time, in milliseconds, that the App Store signed the JSON Web Signature data.
    /// </summary>
    /// <remarks>
    /// See <a href="https://developer.apple.com/documentation/appstoreserverapi/signeddate">signedDate</a>
    /// </remarks>
    [JsonPropertyName("signedDate")]
    public long? SignedDate { get; set; }
}
