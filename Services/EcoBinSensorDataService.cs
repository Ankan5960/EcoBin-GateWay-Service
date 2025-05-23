using EcoBin_GateWay_Service.Model;
using EcoBin_GateWay_Service.Model.DTOs.Requests;
using EcoBin_GateWay_Service.Model.DTOs.Response;
using EcoBin_GateWay_Service.Model.DTOs.Responses;
using EcoBin_GateWay_Service.Services.Contracts;

namespace EcoBin_GateWay_Service.Services;

public class EcoBinSensorDataService : HttpClientBase, IEcoBinSensorDataService
{
    private readonly string _baseUrl;

    public EcoBinSensorDataService(IConfiguration configuration, HttpClient httpClient) : base(httpClient)
    {
        _baseUrl = configuration["ApiBaseUrls:EcoBinSensorDataService"] ?? throw new ArgumentNullException("ApiBaseUrls:EcoBinSensorDataService");
    }

    public async Task<SetupResponseDto> SetupAsync(SetupRequestDto setupRequestDto)
    {
        var url = $"{_baseUrl}/api/DustbinSetup/setup";
        var response = await PostAsync<SetupRequestDto, SetupResponseDto>(url, setupRequestDto);
        ArgumentNullException.ThrowIfNull(response);
        return response;
    }

    public async Task<DustbinDetailsDataResponseModel> GetSetupAsync(Guid dustbinId)
    {
        var url = $"{_baseUrl}/api/DustbinSetup/getsetup?dustbinId={dustbinId}";
        var response = await GetAsync<DustbinDetailsDataResponseModel>(url);
        ArgumentNullException.ThrowIfNull(response);
        return response;
    }

    public async Task<DeleteSetupAsyncResponseDto> DeleteSetupAsync(Guid dustbinId)
    {
        var url = $"{_baseUrl}/api/DustbinSetup/deleteSetup?dustbinId={dustbinId}";
        var response = await DeleteAsync<DeleteSetupAsyncResponseDto>(url);
        ArgumentNullException.ThrowIfNull(response);
        return response;
    }

    public async Task<List<DustbinDataResponseDto>> GetDustbinDetailsByRegionData(RegionRequestDto regionRequestDto)
    {
        var queryParams = new List<string>();

        if (!string.IsNullOrWhiteSpace(regionRequestDto.CountryName))
            queryParams.Add($"CountryName={Uri.EscapeDataString(regionRequestDto.CountryName)}");

        if (!string.IsNullOrWhiteSpace(regionRequestDto.RegionName))
            queryParams.Add($"RegionName={Uri.EscapeDataString(regionRequestDto.RegionName)}");

        if (!string.IsNullOrWhiteSpace(regionRequestDto.DistrictName))
            queryParams.Add($"DistrictName={Uri.EscapeDataString(regionRequestDto.DistrictName)}");

        if (!string.IsNullOrWhiteSpace(regionRequestDto.PlaceName))
            queryParams.Add($"PlaceName={Uri.EscapeDataString(regionRequestDto.PlaceName)}");

        if (!string.IsNullOrWhiteSpace(regionRequestDto.LocalityName))
            queryParams.Add($"LocalityName={Uri.EscapeDataString(regionRequestDto.LocalityName)}");

        if (!string.IsNullOrWhiteSpace(regionRequestDto.AddressName))
            queryParams.Add($"AddressName={Uri.EscapeDataString(regionRequestDto.AddressName)}");

        if (!string.IsNullOrWhiteSpace(regionRequestDto.PinCode))
            queryParams.Add($"PinCode={Uri.EscapeDataString(regionRequestDto.PinCode)}");

        var queryString = string.Join("&", queryParams);


        var url = $"{_baseUrl}/api/Dustbin/get-dustbin-details-by-region-data?";
        if (queryParams.Count > 0)
        {
            url += "?" + queryString;
        }

        var response = await GetAsync<List<DustbinDataResponseDto>>(url);
        ArgumentNullException.ThrowIfNull(response);
        return response;
    }

    public async Task<ReportDataResponse> GetTotalDustbinAsync()
    {
        var url = $"{_baseUrl}/api/ReportData/getReportData";
        var response = await GetAsync<ReportDataResponse>(url);
        ArgumentNullException.ThrowIfNull(response);
        return response;
    }

    public async Task<UpdateSensorDataResponseDto> UpdateSensorDataAsync(UpdateSensorDataRequestDto updateSensorDataDto)
    {
        var url = $"{_baseUrl}/api/SensorData/update-location-data";
        var response = await PostAsync<UpdateSensorDataRequestDto, UpdateSensorDataResponseDto>(url, updateSensorDataDto);
        ArgumentNullException.ThrowIfNull(response);
        return response;
    }

    public async Task<UpdateLocationDataResponseDto> UpdateLocationDataAsync(UpdateLocationDataRequestDto updateLocationDataRequestDto)
    {
        var url = $"{_baseUrl}/api/SensorData/update-location-data";
        var response = await PostAsync<UpdateLocationDataRequestDto, UpdateLocationDataResponseDto>(url, updateLocationDataRequestDto);
        ArgumentNullException.ThrowIfNull(response);
        return response;
    }
}