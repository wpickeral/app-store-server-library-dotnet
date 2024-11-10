namespace AppStoreServerLibrary.Models;

public enum VerificationStatus
{
    Ok,
    VerificationFailure,
    InvalidAppIdentifier,
    InvalidEnvironment,
    InvalidChainLength,
    InvalidCertificate,
    Failure
}
