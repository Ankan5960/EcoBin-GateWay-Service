using EcoBin_GateWay_Service.Model.DTOs.Requests;
using EcoBin_GateWay_Service.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcoBin_GateWay_Service.Controllers;

[ApiController]
[Route("ecobin-gateway[controller]")]
public class EcoBinUserDataServiceController : ControllerBase
{
    private readonly IServiceManager _serviceManager;
    public EcoBinUserDataServiceController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }

    [HttpPost("post-contact-us")]
    public async Task<IActionResult> postContactUs([FromForm] ContactUsDto contactUsDto)
    {
        var data = await _serviceManager.EmailService.SendContactEmail(contactUsDto);
        return Ok(data);
    }
    
    [HttpGet("get-user-dustbin-data")]
    public async Task<IActionResult> GetUserDustbinData([FromQuery] UserLocationRequestDto regionRequestDto)
    {
        var data = await _serviceManager.DustbinApiService.GetUserDustbinDataAsync(regionRequestDto);
        return Ok(data);
    }

    [Authorize(Policy = "AdminOnly")]
    [HttpGet("get-collector-dustbin-data")]
    public async Task<IActionResult> GetCollectorDustbinData([FromQuery] CollectorLocationRequestDto collectorLocationRequestDto)
    {
        var data = await _serviceManager.DustbinApiService.GetCollectorDustbinDataAsync(collectorLocationRequestDto);
        return Ok(data);
    }

    [Authorize(Policy = "AdminOnly")]
    [HttpGet("get-collect-path")]
    public async Task<IActionResult> GetCollectPath([FromQuery] CollectorLocationRequestDto collectorLocationRequestDto)
    {
        var data = await _serviceManager.DustbinApiService.GetCollectPathAsync(collectorLocationRequestDto);
        return Ok(data);
    }
}