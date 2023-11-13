namespace CargaSinEstres.API.Security.Domain.Models;

/// <summary>
/// Model for the Client entity
/// </summary>
public class Client{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public string Apellido_paterno { get; set; }

    public string Apellido_materno { get; set; }

    public string Celular { get; set; }

    public string Direccion { get; set; }

    public string Correo { get; set; }

    public string Contraseña { get; set; }

}