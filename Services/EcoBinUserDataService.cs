using EcoBin_GateWay_Service.Services.Contracts;

namespace EcoBin_GateWay_Service.Services;

public class EcoBinUserDataService : IEcoBinUserDataService
{
    private readonly string _baseUrl;
    public EcoBinUserDataService(IConfiguration configuration)
    {
        _baseUrl = configuration["ApiBaseUrls:EcoBinUserDataService"] ?? throw new ArgumentNullException("ApiBaseUrls:EcoBinUserDataService");
    }
}