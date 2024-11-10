namespace AppStoreServerLibrary;

public sealed class AppStoreServerAPIClientOptions
{
    public required string KeyId { get; init; }
    public required string IssuerId { get; init; }
    public required string BundleId { get; init; }
    public required string SigningKey { get; init; }
    public required string Environment { get; init; }
    public string? AppAppleId { get; internal set; }
}
