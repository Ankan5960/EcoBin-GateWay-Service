namespace EcoBin_GateWay_Service.Model.DTOs.Requests;

public class MigrationRequestDto
{
    public List<Loc> Locations { get; set; } = new();

    public class Loc
    {
        public string Latitude { get; set; } = string.Empty;
        public string Longitude { get; set; } = string.Empty;
    }
}