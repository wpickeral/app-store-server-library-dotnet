using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AppStoreServerLibrary;

public static class DIExtensions
{
    public static IServiceCollection AddAppStoreServerLibraryClient(this IServiceCollection services)
    {
        services.AddTransient<AppStoreServerAPIClientHandler>();

        // Create an instance of AppStoreServerAPIClient, passing in the instance of HttpClient to its constructor.
        services.AddHttpClient<IAppStoreServerAPIClient, AppStoreServerAPIClient>()
            .AddHttpMessageHandler<AppStoreServerAPIClientHandler>();

        return services;
    }
}
