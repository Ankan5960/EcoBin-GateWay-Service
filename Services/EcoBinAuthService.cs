using EcoBin_GateWay_Service.DTOs.Requests;
using EcoBin_GateWay_Service.Model.DTOs;
using EcoBin_GateWay_Service.Model.DTOs.Response;
using EcoBin_GateWay_Service.Services.Contracts;

namespace EcoBin_GateWay_Service.Services;

public class EcoBinAuthService : HttpClientBase, IEcoBinAuthService
{
    private readonly string _baseUrl;

    public EcoBinAuthService(IConfiguration configuration, HttpClient httpClient) : base(httpClient)
    {
        _baseUrl = configuration["ApiBaseUrls:EcoBinAuthService"] ?? throw new ArgumentNullException("ApiBaseUrls:EcoBinAuthService");
    }

    public async Task<SignupResponseDto> SignupAsync(SignupRequestDto signupRequestDto)
    {
        var url = $"{_baseUrl}/user-auth/Auth/signup";
        var response = await PostAsync<SignupRequestDto, SignupResponseDto>(url, signupRequestDto);
        ArgumentNullException.ThrowIfNull(response);
        return response;
    }

    public async Task<AuthDto> LoginAsync(LoginRequestDto loginRequest)
    {
        var url = $"{_baseUrl}/user-auth/Auth/login";
        var response = await PostAsync<LoginRequestDto, AuthDto>(url, loginRequest);
        ArgumentNullException.ThrowIfNull(response);
        return response;
    }

    public async Task<RegistrationKeyResponseDto?> CreateRegistrationKeyAsync(Guid roleId)
    {
        var url = $"{_baseUrl}/user-auth/RegistrationKey/create";
        var response = await PostAsync<Guid, RegistrationKeyResponseDto>(url, roleId);
        ArgumentNullException.ThrowIfNull(response);
        return response;
    }
}