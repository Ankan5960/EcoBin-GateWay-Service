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
    public ServiceManager(IEcoBinAuthService ecoBinAuthService, IEcoBinSensorDataService ecoBinSensorDataService, IEcoBinUserDataService ecoBinUserDataService)
    {
        _ecoBinAuthService = new Lazy<IEcoBinAuthService>(() => ecoBinAuthService);
        _ecoBinSensorDataService = new Lazy<IEcoBinSensorDataService>(() => ecoBinSensorDataService);
        _ecoBinUserDataService = new Lazy<IEcoBinUserDataService>(() => ecoBinUserDataService);
    }
}