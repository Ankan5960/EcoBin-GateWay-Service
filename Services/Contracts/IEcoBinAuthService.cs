using EcoBin_GateWay_Service.DTOs.Requests;
using EcoBin_GateWay_Service.Model.DTOs;
using EcoBin_GateWay_Service.Model.DTOs.Requests;
using EcoBin_GateWay_Service.Model.DTOs.Response;

namespace EcoBin_GateWay_Service.Services.Contracts;

public interface IEcoBinAuthService : IHttpClientBase
{
    Task<SignupResponseDto> SignupAsync(SignupRequestDto signupRequestDto);
    Task<AuthDto> LoginAsync(LoginRequestDto loginRequest);
    Task<RegistrationKeyResponseDto?> CreateRegistrationKeyAsync(RegistrationKeyRequestDto registrationKeyRequestDto);
    Task<IEnumerable<RoleIdResponseDto>?> GetRoleIdAsync();
    Task<AuthDto> PostRefreshTokenAsync(RefreshTokenRequestDto request);
}