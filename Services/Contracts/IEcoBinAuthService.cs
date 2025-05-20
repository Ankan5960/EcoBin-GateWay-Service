using EcoBin_GateWay_Service.DTOs.Requests;
using EcoBin_GateWay_Service.Model.DTOs;

namespace EcoBin_GateWay_Service.Services.Contracts;

public interface IEcoBinAuthService : IHttpClientBase
{
    Task<AuthDto> LoginAsync(string url, LoginRequestDto loginRequest);
}