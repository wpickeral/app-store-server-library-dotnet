using System.Security.Cryptography.X509Certificates;


namespace AppStoreServerLibrary;

public class CertificateProcessor
{
    public List<X509Certificate2> GetCertificateChain(List<string> base64Certs)
    {
        // Slice the chain (take the first two certificates)
        var certsToProcess = base64Certs.GetRange(0, Math.Min(2, base64Certs.Count));

        var certificateChain = new List<X509Certificate2>();

        foreach (var certBase64 in certsToProcess)
        {
            // Convert the base64 string into a byte array
            var certBytes = Convert.FromBase64String(certBase64);

            // Create the X509Certificate2 object from the byte array
            var certificate = new X509Certificate2(certBytes);

            // Add the certificate to the chain
            certificateChain.Add(certificate);
        }

        return certificateChain;
    }
}

