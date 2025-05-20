namespace EcoBin_GateWay_Service.Extensions.Exceptions;

public class BadRequestException : Exception
{
    public BadRequestException(string message) : base(message)
    {
    }
}