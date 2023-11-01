using System.ComponentModel.DataAnnotations;

namespace CargaSinEstres.API.Company.Domain.Services.Communication;

public class RegisterRequest
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Photo { get; set; }
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
    [Required]
    public bool Transporte { get; set; }
    [Required]
    public bool Carga { get; set; }
    [Required]
    public bool Embalaje { get; set; }
    [Required]
    public bool Montaje { get; set; }
    [Required]
    public bool Desmontaje { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string UserType { get; set; }
    [Required]
    public int AverageRating { get; set; }
}