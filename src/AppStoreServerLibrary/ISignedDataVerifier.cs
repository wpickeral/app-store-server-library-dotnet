using AppStoreServerLibrary.Models;

public interface ISignedDataVerifier
{
    NotificationData ValidateAndDecodeNotificationV2(string signedPayload);
}