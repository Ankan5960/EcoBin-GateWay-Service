using EcoBin_GateWay_Service.Model.DTOs;
using EcoBin_GateWay_Service.Model.DTOs.Requests;
using EcoBin_GateWay_Service.Model.DTOs.response;
using EcoBin_GateWay_Service.Model.DTOs.Responses;

namespace EcoBin_GateWay_Service.Services.Contracts;

public interface IEcoBinUserDataService : IHttpClientBase
{
    Task<ContactUsResponseDto> SendContactEmail(ContactUsRequestDto contactUsDto);
    Task<List<DustbinDataResponseDto>> GetUserDustbinDataAsync(UserLocationRequestDto userlocation);
    Task<List<DustbinDataResponseDto>> GetCollectorDustbinDataAsync(CollectorLocationRequestDto collectorLocation);
    Task<DirectionsResponseDto> GetCollectPathAsync(CollectorLocationRequestDto collectorLocation);
}