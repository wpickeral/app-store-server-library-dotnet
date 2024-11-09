using Microsoft.Extensions.DependencyInjection;

namespace AppStoreServerLibrary;

public static class DIExtensions
{
    public static IServiceCollection AddAppStoreServerLibraryClient(this IServiceCollection services)
    {
        services.AddTransient<AppStoreServerAPIClientHandler>();
        services.AddTransient<IAppStoreServerAPIClient, AppStoreServerAPIClient>();
        services.AddHttpClient<IAppStoreServerAPIClient, AppStoreServerAPIClient>()
            .AddHttpMessageHandler<AppStoreServerAPIClientHandler>();

        return services;
    }
}
