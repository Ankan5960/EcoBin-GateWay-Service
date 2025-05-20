using EcoBin_GateWay_Service.Model.DTOs.Requests;
using EcoBin_GateWay_Service.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcoBin_GateWay_Service.Controllers;

[ApiController]
[Route("ecobin-gateway[controller]")]
public class EcoBinSensorDataServiceControllers : ControllerBase
{
    private readonly IServiceManager _serviceManager;
    public EcoBinSensorDataServiceControllers(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }

    [Authorize(Policy = "AdminOnly")]
    [HttpPost("setup")]
    public async Task<IActionResult> Setup([FromBody] SetupRequestDto signupRequest)
    {
        //var dustbinId = await _serviceManager.AdminSetupService.SetupAsync(signupRequest);
        //return Ok(dustbinId);
    }

    [Authorize(Policy = "AdminOnly")]
    [HttpGet("getsetup")]
    public async Task<IActionResult> GetSetup([FromQuery] Guid dustbinId)
    {
        // var dustbin = await _serviceManager.AdminSetupService.GetSetupAsync(dustbinId);
        // return Ok(dustbin);
    }

    [Authorize(Policy = "AdminOnly")]
    [HttpDelete("deleteSetup")]
    public async Task<IActionResult> DeleteSetup([FromQuery] Guid DustbinId)
    {
        // await _serviceManager.AdminSetupService.DeleteSetupAsync(DustbinId);
        // return Ok("Dustbin deleted succesfully");
    }

    [HttpGet("get-dustbin-details-by-region-data")]
    public async Task<IActionResult> GetDustbinDetailsByCityData([FromQuery] RegionRequestDto regionRequestDto)
    {
        // var result = await _serviceManager.DustbinDetailsService.GetDustbinDetailsByRegionData(regionRequestDto);
        // return Ok(result);
    }

    // [HttpPost("migrate")]
    // public async Task<IActionResult> Migrate([FromBody] MigrationRequestDto request)
    // {
    //     await _serviceManager.MigrationService.Migrate(request);
    //     return Ok("Migration Completed");
    // }

    [HttpGet("getReportData")]
    public async Task<IActionResult> GetReportData()
    {
        // var result = await _serviceManager.ReportDataService.GetTotalDustbinAsync();
        // return Ok(result);
    }
    
    [Authorize(Policy = "AdminOnly")]
    [HttpPost("update-location-data")]
    public async Task<IActionResult> UpdateLocationData([FromBody] UpdateLocationDataRequestDto updateLocationDataRequestDto)
    {
        try
        {
            await _serviceManager.SensorDataService.UpdateLocationDataAsync(updateLocationDataRequestDto);
            return Ok("Location is updated sucessfully");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [Authorize(Policy = "AdminOnly")]
    [HttpPost("update-sensor-data")]
    public async Task<IActionResult> UpdateSensorData([FromBody] UpdateSensorDataDto updateSensorDataDto)
    {
        try
        {
            await _serviceManager.SensorDataService.UpdateSensorDataAsync(updateSensorDataDto);
            return Ok("Sensor Data is updated sucessfully");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}