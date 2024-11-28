namespace AppStoreServerLibrary.Models;

public class NotificationData
{
   public ResponseBodyV2DecodedPayload? SignedData { get; set; }
   public JWSRenewalInfoDecodedPayload? RenewalData { get; set; }
   public JWSTransactionDecodedPayload? TransactionData { get; set; }
}
