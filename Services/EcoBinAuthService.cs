using EcoBin_GateWay_Service.Services.Contracts;

namespace EcoBin_GateWay_Service.Services;

public class EcoBinAuthService : IEcoBinAuthService
{
    private readonly string _baseUrl;
    public EcoBinAuthService(IConfiguration configuration)
    {
        _baseUrl = configuration["ApiBaseUrls:EcoBinAuthService"] ?? throw new ArgumentNullException("ApiBaseUrls:EcoBinAuthService");
    }
}