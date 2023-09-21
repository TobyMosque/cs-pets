using OpenApi.Pets.Sdk.Api;

namespace TobyMosque.Sample.Pets.Api.Services;
public interface IApi
{
    HttpClient HttpClient { get; }

    IPetApi Pet { get; }
    IStoreApi Store { get; }
    IUserApi User { get; }
}
