namespace EcoBin_GateWay_Service.Model.DTOs;

public class ContactUsRequestDto
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Subject { get; set; }
    public string? Message { get; set; }
}