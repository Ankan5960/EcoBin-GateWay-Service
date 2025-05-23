namespace EcoBin_GateWay_Service.Model.DTOs.Requests;

public class UpdateSensorDataRequestDto
{
    public string DustbinId { get; set; } = string.Empty;
    public string WeightData { get; set; } = string.Empty;
    public string AirQualityData { get; set; } = string.Empty;
    public string LevelFillData { get; set; } = string.Empty;
}