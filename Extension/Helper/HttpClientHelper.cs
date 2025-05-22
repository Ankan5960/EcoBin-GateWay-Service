using System.Text.Json;

namespace EcoBin_GateWay_Service.Extension.Helpers;

public class HttpClientHelper
{
    private readonly HttpClient _httpClient;

    public HttpClientHelper(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<T?> GetAsync<T>(string url)
    {
        var response = await _httpClient.GetAsync(url);
         if (!response.IsSuccessStatusCode)
            return default;

        var content = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
    }
}