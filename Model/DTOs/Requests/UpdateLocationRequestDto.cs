namespace EcoBin_GateWay_Service.Model.DTOs.Requests;

public class UpdateLocationDataRequestDto
{
    public string DustbinId { get; set; } = string.Empty;
    public string Latitude { get; set; } = string.Empty;
    public string Longitude { get; set; } = string.Empty;
}