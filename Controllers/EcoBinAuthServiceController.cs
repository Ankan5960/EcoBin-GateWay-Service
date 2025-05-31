using EcoBin_GateWay_Service.DTOs.Requests;
using EcoBin_GateWay_Service.Extensions.Exceptions;
using EcoBin_GateWay_Service.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EcoBin_GateWay_Service.Controllers;

[ApiController]
[Route("ecobin-gateway")]
public class EcoBinAuthServiceController : ControllerBase
{
    private readonly IServiceManager _serviceManager;
    public EcoBinAuthServiceController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }

    [HttpPost("/api/user-auth/auth/signup")]
    public async Task<IActionResult> Signup([FromBody] SignupRequestDto signupRequest)
    {
        var response = await _serviceManager.EcoBinAuthService.SignupAsync(signupRequest);
        return Ok(response);
    }

    [HttpPost("/api/user-auth/auth/login")]
    public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequest)
    {
        var result = await _serviceManager.EcoBinAuthService.LoginAsync(loginRequest);
        return Ok(result);
    }

    [HttpPost("/api/user-auth/RegistrationKey/create")]
    public async Task<IActionResult> CreateRegistrationKey([FromBody] Guid roleId)
    {
        if (roleId == Guid.Empty)
            throw new BadRequestException("Role ID is required.");

        var key = await _serviceManager.EcoBinAuthService.CreateRegistrationKeyAsync(roleId);
        return Ok(key);
    }

    [HttpGet("/api/user-auth/RegistrationKey/get-role-id")]
    public async Task<IActionResult> GetRoleId()
    {
        var key = await _serviceManager.EcoBinAuthService.GetRoleIdAsync();
        return Ok(key);
    }
}