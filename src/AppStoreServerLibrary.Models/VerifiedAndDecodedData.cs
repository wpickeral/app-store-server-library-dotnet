namespace AppStoreServerLibrary.Models;

public class VerifiedAndDecodedData<T>
{
    public T? DecodedData { get; set; }
    public bool IsValid { get; set; }
}
