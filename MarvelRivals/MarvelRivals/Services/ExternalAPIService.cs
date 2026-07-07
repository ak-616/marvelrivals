namespace MarvelRivals.Services
{
    using System.Text.Json;

    public class ExternalAPIService
    {
        private readonly HttpClient _http;
        private readonly string _apiKey;

        public ExternalAPIService(HttpClient http, IConfiguration config)
        {
            _http = http;
            _apiKey = config["ExternalApi:Key"];
        }

        public async Task<string> GetHeroNamesAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://marvelrivalsapi.com/api/v1/heroes");
            request.Headers.Add("x-api-key", _apiKey);

            var response = await _http.SendAsync(request);
            var json = await response.Content.ReadAsStringAsync();

            return json; // just return raw for now so we can see the real shape
        }
    }
}
