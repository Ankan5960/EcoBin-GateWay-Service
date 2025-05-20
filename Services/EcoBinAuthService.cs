using EcoBin_GateWay_Service.DTOs.Requests;
using EcoBin_GateWay_Service.Model.DTOs;
using EcoBin_GateWay_Service.Services.Contracts;

namespace EcoBin_GateWay_Service.Services;

public class EcoBinAuthService : HttpClientBase, IEcoBinAuthService
{
    public EcoBinAuthService(HttpClient httpClient) : base(httpClient)
    {

    }

    public async Task<AuthDto> LoginAsync(string url, LoginRequestDto loginRequest)
    {
        var response = await PostAsync<LoginRequestDto, AuthDto>(url, loginRequest);
        ArgumentNullException.ThrowIfNull(response);
        return response;
    }
}