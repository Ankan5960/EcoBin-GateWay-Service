namespace EcoBin_GateWay_Service.Services.Contracts;

public interface IServiceManager
{
    IEcoBinAuthService EcoBinAuthService { get; }
    IEcoBinSensorDataService EcoBinSensorDataService { get; }
    IEcoBinUserDataService EcoBinUserDataService { get; }
}