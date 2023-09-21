using OpenApi.Pets.Sdk.Api;

namespace TobyMosque.Sample.Pets.Api.Services;
public class Settings : ISettings
{
    public string BaseUrl { get; } = "https://petstore3.swagger.io";
    public string ClientId { get; } = string.Empty;
    public string ApiKey { get; } = string.Empty;
}
