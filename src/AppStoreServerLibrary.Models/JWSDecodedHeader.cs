using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

/// <summary>
/// A decoded JSON Web Signature (JWS) header containing transaction or renewal information.
/// </summary>
/// <remarks>
/// See: <a href="https://developer.apple.com/documentation/appstoreserverapi/jwsdecodedheader">JWSDecodedHeader</a>
/// </remarks> 
public class JWSDecodedHeader
{
    /// <summary>
    /// The algorithm used for signing the JSON Web Signature (JWS).
    /// </summary>
    [JsonPropertyName("alg")]
    public string? Alg { get; set; }

    /// <summary>
    /// The X.509 certificate chain that corresponds to the key that the App Store used to secure the JWS.
    /// </summary>
    [JsonPropertyName("x5c")]
    public string[]? X5c { get; set; }
}