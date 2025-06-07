using EcoBin_GateWay_Service.Model.DTOs;
using EcoBin_GateWay_Service.Model.DTOs.Requests;
using EcoBin_GateWay_Service.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EcoBin_GateWay_Service.Controllers;

[ApiController]
[Route("ecobin-gateway")]
public class EcoBinUserDataServiceController : ControllerBase
{
    private readonly IServiceManager _serviceManager;
    public EcoBinUserDataServiceController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }

    [HttpPost("/api/user-data/post-contact-us")]
    public async Task<IActionResult> postContactUs([FromBody] ContactUsRequestDto contactUsDto)
    {
        var data = await _serviceManager.EcoBinUserDataService.SendContactEmail(contactUsDto);
        return Ok(data);
    }

    [HttpGet("/api/user-data/get-user-dustbin-data")]
    public async Task<IActionResult> GetUserDustbinData([FromQuery] UserLocationRequestDto regionRequestDto)
    {
        var data = await _serviceManager.EcoBinUserDataService.GetUserDustbinDataAsync(regionRequestDto);
        return Ok(data);
    }

    [HttpGet("/api/user-data/get-collector-dustbin-data")]
    public async Task<IActionResult> GetCollectorDustbinData([FromQuery] CollectorLocationRequestDto collectorLocationRequestDto)
    {
        var data = await _serviceManager.EcoBinUserDataService.GetCollectorDustbinDataAsync(collectorLocationRequestDto);
        return Ok(data);
    }

    [HttpGet("/api/user-data/get-collect-path")]
    public async Task<IActionResult> GetCollectPath([FromQuery] CollectorLocationRequestDto collectorLocationRequestDto)
    {
        var data = await _serviceManager.EcoBinUserDataService.GetCollectPathAsync(collectorLocationRequestDto);
        return Ok(data);
    }
    
    [HttpGet("/api/user-data/get-user-path")]
    public async Task<IActionResult> GetUserPath([FromQuery] UserLocationRequestDto userLocationRequestDto)
    {
        var data = await _serviceManager.EcoBinUserDataService.GetUserPathAsync(userLocationRequestDto);
        return Ok(data);
    }
}