namespace EcoBin_GateWay_Service.DTOs.Requests;

public class LoginRequestDto
{
    public string email { get; set; } = string.Empty;
    public string password { get; set; } = string.Empty;
    public string ipAddress { get; set; } = string.Empty;
    public string deviceInfo { get; set; } = string.Empty;
}
