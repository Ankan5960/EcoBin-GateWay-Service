namespace EcoBin_GateWay_Service.Model.DTOs.Requests;

public class LogoutResponseDto
{
    public bool IsLoggedOut { get; set; }
    public string Message { get; set; } = string.Empty;
}
