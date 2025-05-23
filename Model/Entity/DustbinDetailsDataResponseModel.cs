namespace EcoBin_GateWay_Service.Model;

public class DustbinDetailsDataResponseModel
{
    public Guid DustbinId { get; set; }
    public Guid LocationDataId { get; set; }
    public string Latitude { get; set; } = string.Empty;
    public string Longitude { get; set; } = string.Empty;
    public Guid RegionId { get; set; }
    public string CountryName { get; set; } = string.Empty;
    public string RegionName { get; set; } = string.Empty;
    public string DistrictName { get; set; } = string.Empty;
    public string PlaceName { get; set; } = string.Empty;
    public string LocalityName { get; set; } = string.Empty;
    public string AddressName { get; set; } = string.Empty;
    public string PinCode { get; set; } = string.Empty;
    public Guid SensorDataId { get; set; }
    public string? WeightData { get; set; }
    public string? AirQualityData { get; set; }
    public string? LevelFillData { get; set; }
    public Guid CategoryId { get; set; }
    public string CategoryName { get; set; } = string.Empty;
}