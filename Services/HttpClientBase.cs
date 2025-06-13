using EcoBin_GateWay_Service.Model.DTOs;
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
        return await HandleResponse<TResponse>(response);
    }

    public async Task<TResponse?> GetAsync<TResponse>(string url)
    {
        var response = await _httpClient.GetAsync(url);
        return await HandleResponse<TResponse>(response);
    }

    public async Task<TResponse?> DeleteAsync<TResponse>(string url)
    {
        var response = await _httpClient.DeleteAsync(url);
        return await HandleResponse<TResponse>(response);
    }

    private async Task<TResponse?> HandleResponse<TResponse>(HttpResponseMessage response)
    {
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<TResponse>();
        }

        var errorDetails = new ErrorDetailsDto
        {
            StatusCode = (int)response.StatusCode,
            ErrorType = response.StatusCode.ToString(),
            Message = "An error occurred while processing the HTTP request.",
            DetailedMessage = await response.Content.ReadAsStringAsync(),
            InnerExceptions = null
        };

        throw new HttpRequestException(
            System.Text.Json.JsonSerializer.Serialize(errorDetails),
            null,
            response.StatusCode
        );
    }
}
