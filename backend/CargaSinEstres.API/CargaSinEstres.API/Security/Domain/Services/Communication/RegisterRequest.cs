using System.ComponentModel.DataAnnotations;

namespace CargaSinEstres.API.CargaSinEstres.Security.Domain.Services.Communication;

public class RegisterRequest
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string Direccion { get; set; }
    [Required]
    public string NumeroContacto { get; set; }
    [Required]
    public string ConfirmarPassword { get; set; }
    //public bool Transporte { get; set; }
    //public bool Carga { get; set; }
    //public bool Embalaje { get; set; }
    //public bool Montaje { get; set; }
    //public bool Desmontaje { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string UserType { get; set; }
}