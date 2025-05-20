using EcoBin_GateWay_Service.DTOs.Requests;
using EcoBin_GateWay_Service.Extensions.Exceptions;
using EcoBin_GateWay_Service.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcoBin_GateWay_Service.Controllers;

[ApiController]
[Route("ecobin-gateway/user-auth/[controller]")]
public class EcoBinAuthServiceController : ControllerBase
{
    private readonly IServiceManager _serviceManager;
    public EcoBinAuthServiceController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }

    [HttpPost("signup")]
    public async Task<IActionResult> Signup([FromBody] SignupRequestDto signupRequest)
    {
        var userId = await _serviceManager.EcoBinAuthService.SignupAsync(signupRequest);
        return Ok(new { UserId = userId });
    }

    // [HttpPost("login")]
    // public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequest)
    // {
    //     var result = await _serviceManager.EcoBinAuthService.LoginAsync(loginRequest);
    //     return Ok(result);
    // }

    // [HttpPost("db-migrate")]
    // public async Task<IActionResult> Migrate([FromBody] string key)
    // {
    //     MigrationResponseDto response = await _serviceManager.;
    //     return Ok(response);
    // }

    // [HttpPost("create")]
    // public async Task<IActionResult> CreateRegistrationKey([FromBody] Guid roleId)
    // {
    //     if (roleId == Guid.Empty)
    //         throw new BadRequestException("Role ID is required.");

    //     var key = await _serviceManager.RegistrationKeysService.CreateRegistrationKeyAsync(roleId);
    //     return Ok(key);
    // }
}