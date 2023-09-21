using TobyMosque.Sample.Pets.Api.Services;

namespace TobyMosque.Sample.Pets.Api.Handlers
{
    internal class ApiHttpClientHandler : DelegatingHandler
    {
        private readonly ISettings _settings;

        public ApiHttpClientHandler(ISettings settings)
        {
            _settings = settings;
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            if (!string.IsNullOrWhiteSpace(this._settings.ApiKey))
            {
                request.Headers.Add("api_key", this._settings.ApiKey);
            }
            var response = await base.SendAsync(request, cancellationToken);
            return response;
        }
    }
}
