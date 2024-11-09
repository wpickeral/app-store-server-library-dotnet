# app-store-server-library-dotnet

A .NET 8 implementation of the [App Store Server Library](https://developer.apple.com/documentation/appstoreserverapi/simplifying_your_implementation_by_using_the_app_store_server_library).

## Configuration

appsettings.json
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
   "AppStoreServerLibrary": {
    "KeyId": "[YOUR_KEY_ID]",
    "IssuerId": "[YOUR_ISSUER_ID",
    "BundleId": "[YOUR_BUNDLE_ID]",
    "Environment": "Sandbox", 
    "SigningKey": "[YOUR_SIGNING_KEY]"
  }
}
```
Reference: [Generating JSON Web Tokens for API requests](https://developer.apple.com/documentation/appstoreserverapi/generating_json_web_tokens_for_api_requests)


## Required Services

```cs
builder.Services.Configure<AppStoreServerAPIClientOptions>(
   builder.Configuration.GetSection(
    key: nameof(AppStoreServerLibrary)));

builder.Services.AddAppStoreServerLibraryClient();

```

## Features
- Provides an API client that encodes App Store Server API requests, decodes the responses, and creates the JSON Web Token (JWT) you use to authenticate the calls.


## Sample Application
Please checkout `AppStoreServerLibrary.SampleWebAPI` to see a sample implementation.


