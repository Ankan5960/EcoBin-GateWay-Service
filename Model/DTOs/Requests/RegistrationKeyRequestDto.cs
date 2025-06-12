namespace EcoBin_GateWay_Service.Model.DTOs.Requests;

public class RegistrationKeyRequestDto
{
    public Guid RoleId { get; set; }
    public string? AreaOfService { get; set; }
}