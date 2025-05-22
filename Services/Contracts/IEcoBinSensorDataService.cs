using EcoBin_GateWay_Service.Model;
using EcoBin_GateWay_Service.Model.DTOs.Requests;
using EcoBin_GateWay_Service.Model.DTOs.Response;
using EcoBin_GateWay_Service.Model.DTOs.Responses;

namespace EcoBin_GateWay_Service.Services.Contracts;

public interface IEcoBinSensorDataService : IHttpClientBase
{
    Task<SetupResponseDto> SetupAsync(SetupRequestDto setupRequestDto);
    Task<DustbinDetailsDataResponseModel> GetSetupAsync(Guid dustbinId);
    Task DeleteSetupAsync(Guid dustbinId);
    Task<List<DustbinDataResponseDto>> GetDustbinDetailsByRegionData(RegionRequestDto regionRequestDto);
    Task<ReportDataResponse> GetTotalDustbinAsync();
    Task UpdateSensorDataAsync(UpdateSensorDataRequestDto updateSensorDataDto);
    Task UpdateLocationDataAsync(UpdateLocationDataRequestDto updateLocationDataRequestDto);
}