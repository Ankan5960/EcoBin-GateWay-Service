namespace EcoBin_GateWay_Service.Model.DTOs.Responses;

public class ReportDataResponse
{
    public string TotalDustbins { get; set; } = string.Empty;
    public string TotalActiveDustbins { get; set; } = string.Empty;
    public string TotalWeightData { get; set; } = string.Empty;
    public string TotalAirQualityData { get; set; } = string.Empty;
    public Dictionary<string, int> Categories { get; set; } = [];
}