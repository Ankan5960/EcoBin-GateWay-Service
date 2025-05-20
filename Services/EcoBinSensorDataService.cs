using EcoBin_GateWay_Service.Services.Contracts;

namespace EcoBin_GateWay_Service.Services;

public class EcoBinSensorDataService : IEcoBinSensorDataService
{
    private readonly string _baseUrl;
    public EcoBinSensorDataService(IConfiguration configuration)
    {
        _baseUrl = configuration["ApiBaseUrls:EcoBinSensorDataService"] ?? throw new ArgumentNullException("ApiBaseUrls:EcoBinSensorDataService");
    }
}