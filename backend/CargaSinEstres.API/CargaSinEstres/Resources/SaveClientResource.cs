using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace CargaSinEstres.API.CargaSinEstres.Resources;

[SwaggerSchema(Required = new []{"Name"})]
public class SaveClientResource
{
    [SwaggerSchema("Client Name")]
    [Required]
    public string Nombre { get; set; }
    [Required]
    public string apellido_paterno{ get; set; }
    [Required]
    public string apellido_materno { get; set; }
    [Required]
    public string Celular { get; set; }
    [Required]
    public string Direccion { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
}