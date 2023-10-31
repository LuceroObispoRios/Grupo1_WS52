using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace CargaSinEstres.API.CargaSinEstres.Resources;

[SwaggerSchema(Required = new []{"Name"})]
public class SaveClientResource
{
    [SwaggerSchema("Client Name")]
    [Required]
    public string Nombre { get; set; }
}