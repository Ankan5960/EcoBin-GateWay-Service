using EcoBin_GateWay_Service.DTOs.Requests;
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

    [HttpPost("/user-auth/auth/login")]
    public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequest)
    {
        var url = "http://localhost:5117/user-auth/Auth/login";
        var result = await _serviceManager.EcoBinAuthService.LoginAsync(url, loginRequest);
        return Ok(result);
    }
}