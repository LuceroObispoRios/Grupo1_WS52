namespace CargaSinEstres.API.Security.Domain.Services.Communication;

public class AuthenticateResponseClient
{
    public int Id { get; set; }
    public string Correo { get; set; }
    public string Contraseña { get; set; }
}