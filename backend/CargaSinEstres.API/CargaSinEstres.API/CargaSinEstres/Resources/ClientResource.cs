using Swashbuckle.AspNetCore.Annotations;

namespace CargaSinEstres.API.CargaSinEstres.Resources;

public class ClientResource
{
    [SwaggerSchema("Client Identifier")]
    public int Id { get; set; }
    [SwaggerSchema("Client Name")]
    public string Nombre { get; set; }
}
