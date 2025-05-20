using EcoBin_GateWay_Service.Services.Contracts;

namespace EcoBin_GateWay_Service.Services;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<IEcoBinAuthService> _ecoBinAuthService;
    private readonly Lazy<IEcoBinSensorDataService> _ecoBinSensorDataService;
    private readonly Lazy<IEcoBinUserDataService> _ecoBinUserDataService;

    public IEcoBinAuthService EcoBinAuthService => _ecoBinAuthService.Value;
    public IEcoBinSensorDataService EcoBinSensorDataService => _ecoBinSensorDataService.Value;
    public IEcoBinUserDataService EcoBinUserDataService => _ecoBinUserDataService.Value;

    public ServiceManager( IConfiguration configuration)
    {
        _ecoBinAuthService = new Lazy<IEcoBinAuthService>(() => new EcoBinAuthService(configuration));
        _ecoBinSensorDataService = new Lazy<IEcoBinSensorDataService>(() => new EcoBinSensorDataService(configuration));
        _ecoBinUserDataService = new Lazy<IEcoBinUserDataService>(() => new EcoBinUserDataService(configuration));
    }
}