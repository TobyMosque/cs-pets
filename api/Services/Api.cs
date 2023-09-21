using OpenApi.Pets.Sdk.Api;

namespace TobyMosque.Sample.Pets.Api.Services;
public class Api : IApi
{
    public Api(HttpClient httpClient, IPetApi pet, IStoreApi store, IUserApi user)
    {

        HttpClient = httpClient;
        Pet = pet;
        Store = store;
        User = user;
    }

    public HttpClient HttpClient { get; }

    public IPetApi Pet { get; }
    public IStoreApi Store { get; }
    public IUserApi User { get; }
}
