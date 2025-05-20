using EcoBin_GateWay_Service.DTOs.Requests;

namespace EcoBin_GateWay_Service.Services.Contracts;

public interface IEcoBinAuthService
{
    Task<Guid> SignupAsync(SignupRequestDto signupRequest);
    //Task<AuthDto> LoginAsync(LoginRequestDto loginRequest);

}