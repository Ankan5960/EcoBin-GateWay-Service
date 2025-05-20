namespace EcoBin_GateWay_Service.Model.DTOs.Response;

public class MigrationResponseDto
{
    public string Info { get; set; } = "Database migration was successful. Below are the credentials for the admin user.";
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}