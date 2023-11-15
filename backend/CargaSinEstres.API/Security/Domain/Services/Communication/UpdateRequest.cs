using CargaSinEstres.API.CargaSinEstres.Domain.Models;

namespace CargaSinEstres.API.Security.Domain.Services.Communication;

public class UpdateRequest
{
    public string Name { get; set; }
    public string Photo { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Direccion { get; set; }
    public string NumeroContacto { get; set; }
    public string ConfirmarPassword { get; set; }
    public bool Transporte { get; set; }
    public bool Carga { get; set; }
    public bool Embalaje { get; set; }
    public bool Montaje { get; set; }
    public bool Desmontaje { get; set; }
    public string Description { get; set; }
    public string UserType { get; set; }
    public int AverageRating { get; set; }
}