using System.ComponentModel.DataAnnotations;

namespace CargaSinEstres.API.CargaSinEstres.Security.Domain.Services.Communication;

public class AuthenticateRequest
{
    [Required] public string Email { get; set; }

    [Required] public string Password { get; set; }
}
