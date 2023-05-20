using System.Net.Http.Json;
using System.Text.Json;

namespace Frontend.Client
{
    public class BaseClient
    {
        private readonly string _baseUrl;
        private readonly HttpClient _httpClient;
        public BaseClient(string baseUrl)
        {
            _baseUrl = baseUrl;
            _httpClient = new HttpClient();
        }

        public string BaseUrl { get => BaseUrl; }
        public HttpClient HttpClient { get => HttpClient; }

        public static async Task<T> DeserializeResponseContentAsync<T>(HttpResponseMessage response) where T : class
        {
            var body = await response.Content.ReadAsStringAsync();
            return Deserialize<T>(body);
        }

        private static T Deserialize<T>(string json) where T : class
        {
            if (string.IsNullOrEmpty(json))
            {
                return null;
            }
            return JsonSerializer.Deserialize<T>(json);
        }

        public async Task<HttpResponseMessage> PostAsync(string url, object body = null)
        {
            return await HttpClient.PostAsJsonAsync(url, body);
        }
    }
}
