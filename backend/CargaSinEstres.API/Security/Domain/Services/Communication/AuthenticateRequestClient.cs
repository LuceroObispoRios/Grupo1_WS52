using System.ComponentModel.DataAnnotations;

namespace CargaSinEstres.API.Security.Domain.Services.Communication;

public class AuthenticateRequestClient
{
    [Required] public string Correo { get; set; }

    [Required] public string Contraseña { get; set; }
}