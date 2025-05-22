using EcoBin_GateWay_Service.Model.Entities;

namespace EcoBin_GateWay_Service.Model.DTOs.Responses;

public class DustbinDataResponseDto
{
    public Guid DustbinId { get; set; }
    public LocationDataResponseDto Location { get; set; } = new();
    public RegionResponseDto Region { get; set; } = new();
    public SensorDataResponseDto SensorData { get; set; } = new();
    public CategoryEntity Category { get; set; } = new();
    public string DistanceFromUser { get; set; } = string.Empty;
    public bool? IsDangrouse { get; set; } = null;
}