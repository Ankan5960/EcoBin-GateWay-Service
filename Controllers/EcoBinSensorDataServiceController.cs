using EcoBin_GateWay_Service.Model.DTOs.Requests;
using EcoBin_GateWay_Service.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EcoBin_GateWay_Service.Controllers;

[ApiController]
[Route("ecobin-gateway")]
public class EcoBinSensorDataServiceController : ControllerBase
{
    private readonly IServiceManager _serviceManager;
    public EcoBinSensorDataServiceController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }

    [HttpPost("/dustbinSetup/setup")]
    public async Task<IActionResult> Setup([FromBody] SetupRequestDto signupRequest)
    {
        var dustbinId = await _serviceManager.EcoBinSensorDataService.SetupAsync(signupRequest);
        return Ok(dustbinId);
    }

    [HttpGet("/dustbinSetup/getsetup")]
    public async Task<IActionResult> GetSetup([FromQuery] Guid dustbinId)
    {
        var dustbin = await _serviceManager.EcoBinSensorDataService.GetSetupAsync(dustbinId);
        return Ok(dustbin);
    }

    [HttpDelete("/dustbinSetup/deleteSetup")]
    public async Task<IActionResult> DeleteSetup([FromQuery] Guid dustbinId)
    {
        var res = await _serviceManager.EcoBinSensorDataService.DeleteSetupAsync(dustbinId);
        return Ok(res);
    }

    [HttpGet("/dustbin/get-dustbin-details-by-region-data")]
    public async Task<IActionResult> GetDustbinDetailsByCityData([FromQuery] RegionRequestDto regionRequestDto)
    {
        var result = await _serviceManager.EcoBinSensorDataService.GetDustbinDetailsByRegionData(regionRequestDto);
        return Ok(result);
    }

    [HttpGet("/report-data/getReportData")]
    public async Task<IActionResult> GetReportData()
    {
        var result = await _serviceManager.EcoBinSensorDataService.GetTotalDustbinAsync();
        return Ok(result);
    }

    [HttpPost("/sensor-data/update-location-data")]
    public async Task<IActionResult> UpdateLocationData([FromBody] UpdateLocationDataRequestDto updateLocationDataRequestDto)
    {
        try
        {
            var response = await _serviceManager.EcoBinSensorDataService.UpdateLocationDataAsync(updateLocationDataRequestDto);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("/sensor-data/update-sensor-data")]
    public async Task<IActionResult> UpdateSensorData([FromBody] UpdateSensorDataRequestDto updateSensorDataDto)
    {
        try
        {
            var response = await _serviceManager.EcoBinSensorDataService.UpdateSensorDataAsync(updateSensorDataDto);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}