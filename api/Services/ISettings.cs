namespace TobyMosque.Sample.Pets.Api.Services;
public interface ISettings
{
    string BaseUrl { get; }
    string ClientId { get; }
    string ApiKey { get; }
}
