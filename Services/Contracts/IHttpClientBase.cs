namespace EcoBin_GateWay_Service.Services.Contracts;

public interface IHttpClientBase
{
    Task<TResponse?> PostAsync<TRequest, TResponse>(string url, TRequest request);
}