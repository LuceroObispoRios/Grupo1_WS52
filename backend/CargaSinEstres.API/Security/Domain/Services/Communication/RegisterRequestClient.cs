using System.ComponentModel.DataAnnotations;

namespace CargaSinEstres.API.Security.Domain.Services.Communication;

public class RegisterRequestClient
{
    [Required]
    public string Nombre { get; set; }

    [Required]
    public string Apellido_paterno { get; set; }

    [Required]
    public string Apellido_materno { get; set; }

    [Required]
    public string Celular { get; set; }

    [Required]
    public string Direccion { get; set; }

    [Required]
    public string Correo { get; set; }

    [Required]
    public string Contraseña { get; set; }
}