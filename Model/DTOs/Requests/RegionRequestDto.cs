namespace EcoBin_GateWay_Service.Model.DTOs.Requests;

public class RegionRequestDto
{
    public string CountryName { get; set; } = string.Empty;
    public string RegionName { get; set; } = string.Empty;
    public string DistrictName { get; set; } = string.Empty;
    public string PlaceName { get; set; } = string.Empty;
    public string LocalityName { get; set; } = string.Empty;
    public string AddressName { get; set; } = string.Empty;
    public string PinCode { get; set; } = string.Empty;
}