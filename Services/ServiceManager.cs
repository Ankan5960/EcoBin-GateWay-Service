using EcoBin_GateWay_Service.Services.Contracts;

namespace EcoBin_GateWay_Service.Services;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<IEcoBinAuthService> _ecoBinAuthService;

    public IEcoBinAuthService EcoBinAuthService => _ecoBinAuthService.Value;

    public ServiceManager(HttpClient httpClient)
    {
        _ecoBinAuthService = new Lazy<IEcoBinAuthService>(() => new EcoBinAuthService(httpClient));
    }
}