using OpenApi.Pets.Sdk.Api;
using TobyMosque.Sample.Pets.Api.Handlers;
using TobyMosque.Sample.Pets.Api.Services;
using ApiClient = TobyMosque.Sample.Pets.Api.Services.Api;
using Polly;

namespace TobyMosque.Sample.Pets.Api.Extensions;
public static class Register
{
    public static void AddPetsApi(this IServiceCollection services)
    {
        services.AddHttpClient<IApi>((provider, client) =>
        {
            var settings = provider.GetRequiredService<ISettings>();
            client.BaseAddress = new Uri(settings.BaseUrl);
        })
                .AddTypedClient<IPetApi>(client => new PetApi(client))
                .AddTypedClient<IStoreApi>(client => new StoreApi(client))
                .AddTypedClient<IUserApi>(client => new UserApi(client))
                .AddHttpMessageHandler((provider) =>
                {
                    var settings = provider.GetRequiredService<ISettings>();
                    return new ApiHttpClientHandler(settings);
                })
                .AddPolicyHandler((provider, request) =>
                {
                    var logger = provider.GetRequiredService<ILogger<ApiHttpClientHandler>>();
                    return Policy
                        .HandleResult<HttpResponseMessage>(request => !request.IsSuccessStatusCode)
                        .WaitAndRetryAsync(3,
                            sleepDurationProvider: (retryAttempt) => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)),
                            onRetry: (response, calculatedWaitDuration) =>
                            {
                                logger.LogError(response.Exception, "Failed attempt. Waited for {0}.",
                                    calculatedWaitDuration);
                            });

                });

        services.AddScoped<IApi, ApiClient>();
        services.AddSingleton<ISettings, Settings>();
    }
}
