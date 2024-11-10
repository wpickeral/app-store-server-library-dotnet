using AppStoreServerLibrary;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services for app-store-server-library-dotnet
builder.Services.Configure<AppStoreServerAPIClientOptions>(
   builder.Configuration.GetSection(
    key: nameof(AppStoreServerLibrary)));

builder.Services.AddAppStoreServerLibraryClient();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

// Diabled to use NGROK for testing
//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
