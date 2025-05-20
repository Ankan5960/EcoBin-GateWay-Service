namespace EcoBin_GateWay_Service.Model.DTOs.Requests;

public class CollectorLocationRequestDto
{
    public string? LocalityName { get; set; } = string.Empty;
    public string Latitude { get; set; } = string.Empty;
    public string Longitude { get; set; } = string.Empty;
}