using EcoBin_GateWay_Service.Services.Contracts;

namespace EcoBin_GateWay_Service.Services;

public class HttpClientBase : IHttpClientBase
{
    protected readonly HttpClient _httpClient;

    public HttpClientBase(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<TResponse?> PostAsync<TRequest, TResponse>(string url, TRequest request)
    {
        var response = await _httpClient.PostAsJsonAsync(url, request);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<TResponse>();
    }
}
