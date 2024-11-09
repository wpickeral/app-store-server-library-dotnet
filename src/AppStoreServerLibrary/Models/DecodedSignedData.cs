using System.Text.Json.Serialization;

namespace AppStoreServerLibrary.Models;

public class DecodedSignedData
{
    [JsonPropertyName("signedDate")]
    public int? SignedDate { get; set; }
}
