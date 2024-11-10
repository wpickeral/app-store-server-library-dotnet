using AppStoreServerLibrary.Models;
using Jose;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using static System.Formats.Asn1.AsnWriter;
using System.Transactions;
using System.Security;
using Microsoft.IdentityModel.JsonWebTokens;

namespace AppStoreServerLibrary.WebAPI.Controllers;

[ApiController]
[Route("/")]
public class AppStoreController : ControllerBase
{

    private readonly ILogger<AppStoreController> _logger;
    private readonly IAppStoreServerAPIClient _appStoreServerAPIClient;
    private readonly ISignedDataVerifier _signedDataVerifier;
    private readonly AppStoreServerAPIClientOptions _options;

    public AppStoreController(ILogger<AppStoreController> logger, IAppStoreServerAPIClient appStoreServerAPIClient, IOptions<AppStoreServerAPIClientOptions> options, ISignedDataVerifier signedDataVerifier)
    {
        _logger = logger;
        _appStoreServerAPIClient = appStoreServerAPIClient;
        _signedDataVerifier = signedDataVerifier;
        _options = options.Value;
    }

    [HttpGet]
    [Route("/notifications/test")]
    public async Task<IResult> SendTestNotification()
    {
        try
        {
            var testNotification = await _appStoreServerAPIClient.RequestTestNotification();

            return Results.Ok(testNotification);
        }
        catch (Exception e)
        {
            _logger.LogError("{Exception}", e);
            return Results.Problem();
        }
    }

    [HttpGet]
    [Route("/notifications/test/{testNotficationToken}")]
    public async Task<IResult> SendTestNotificationStatus(string testNotficationToken)
    {
        try
        {
            var testNotificationStatus = await _appStoreServerAPIClient.GetTestNotificationStatus(testNotficationToken);

            return Results.Ok(testNotificationStatus);
        }
        catch (Exception e)
        {
            _logger.LogError("{Exception}", e);
            return Results.Problem();
        }
    }


    [HttpPost]
    [Route("/notifications")]
    public async Task<IActionResult> NotificationsV2Webhook(CheckTestNotificationResponse checkTestNotificationResponse)
    {
        try
        {
            var signedPayload = checkTestNotificationResponse.SignedPayload ?? throw new Exception("signedPayload not provided in the request");
            var decodedPayload =  _signedDataVerifier.ValidateAndDecodeNotificationV2(checkTestNotificationResponse.SignedPayload);

            _logger.LogInformation("Processing notification type {NotificationType}", decodedPayload?.SignedData?.NotificationType);
            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing the notification.");
            return StatusCode(500, "Internal Server Error");
        }
    }


 
}
