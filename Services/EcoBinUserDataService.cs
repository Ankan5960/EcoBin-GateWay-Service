using EcoBin_GateWay_Service.Model.DTOs;
using EcoBin_GateWay_Service.Model.DTOs.Requests;
using EcoBin_GateWay_Service.Model.DTOs.response;
using EcoBin_GateWay_Service.Model.DTOs.Responses;
using EcoBin_GateWay_Service.Services.Contracts;

namespace EcoBin_GateWay_Service.Services;

public class EcoBinUserDataService : HttpClientBase, IEcoBinUserDataService
{
    private readonly string _baseUrl;

    public EcoBinUserDataService(IConfiguration configuration, HttpClient httpClient) : base(httpClient)
    {
        _baseUrl = configuration["ApiBaseUrls:EcoBinUserDataService"] ?? throw new ArgumentNullException("ApiBaseUrls:EcoBinUserDataService");
    }

    public async Task<ContactUsResponseDto> SendContactEmail(ContactUsRequestDto contactUsDto)
    {
        var url = $"{_baseUrl}/api/ContactUs/post-contact-us";
        var response = await PostAsync<ContactUsRequestDto, ContactUsResponseDto>(url, contactUsDto);
        ArgumentNullException.ThrowIfNull(response);
        return response;
    }

    public async Task<List<DustbinDataResponseDto>> GetUserDustbinDataAsync(UserLocationRequestDto userlocation)
    {
        var url = $"{_baseUrl}/api/DustbinData/get-user-dustbin-data?Latitude={userlocation.Latitude}&Longitude={userlocation.Longitude}";
        var response = await GetAsync<List<DustbinDataResponseDto>>(url);
        ArgumentNullException.ThrowIfNull(response);
        return response;
    }

    public async Task<List<DustbinDataResponseDto>> GetCollectorDustbinDataAsync(CollectorLocationRequestDto collectorLocation)
    {
        var url = $"{_baseUrl}/api/DustbinData/get-collector-dustbin-data?LocalityName={collectorLocation.LocalityName}&Latitude={collectorLocation.Latitude}&Longitude={collectorLocation.Longitude}";
        var response = await GetAsync<List<DustbinDataResponseDto>>(url);
        ArgumentNullException.ThrowIfNull(response);
        return response;
    }

    public async Task<DirectionsResponseDto> GetCollectPathAsync(CollectorLocationRequestDto collectorLocation)
    {
        var url = $"{_baseUrl}/api/DustbinData/get-collect-path?LocalityName={collectorLocation.LocalityName}&Latitude={collectorLocation.Latitude}&Longitude={collectorLocation.Longitude}";
        var response = await GetAsync<DirectionsResponseDto>(url);
        ArgumentNullException.ThrowIfNull(response);
        return response;
    }

    public async Task<DirectionsResponseDto> GetUserPathAsync(UserLocationRequestDto userLocation)
    {
        var url = $"{_baseUrl}/api/DustbinData/get-user-path?Latitude={userLocation.Latitude}&Longitude={userLocation.Longitude}";
        var response = await GetAsync<DirectionsResponseDto>(url);
        ArgumentNullException.ThrowIfNull(response);
        return response;
    }
}