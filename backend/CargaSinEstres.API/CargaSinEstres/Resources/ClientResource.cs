using Swashbuckle.AspNetCore.Annotations;

namespace CargaSinEstres.API.CargaSinEstres.Resources;

public class ClientResource
{
    [SwaggerSchema("Client Identifier")]
    public int Id { get; set; }
    [SwaggerSchema("Client Name")]
    public string Nombre { get; set; }
    public string apellido_paterno{ get; set; }
    public string apellido_materno { get; set; }
    public string Celular { get; set; }
    public string Direccion { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}