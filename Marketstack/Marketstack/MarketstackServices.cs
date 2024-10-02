using Microsoft.Extensions.DependencyInjection;

namespace Marketstack;

public static class MarketstackServices
{
    public static void AddMarketstack(this IServiceCollection services, string apiKey)
    {
        services.AddHttpClient("Marketstack",
            httpClient => { httpClient.BaseAddress = new Uri("http://api.marketstack.com/"); });

        var serviceProvider = services.BuildServiceProvider();

        var fac = services.BuildServiceProvider().GetRequiredService<IHttpClientFactory>();

        services.AddTransient<Marketstack>(_ => new Marketstack(apiKey, fac));
    }
}