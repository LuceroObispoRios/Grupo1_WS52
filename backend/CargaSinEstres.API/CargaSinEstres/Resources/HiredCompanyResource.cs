using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Swashbuckle.AspNetCore.Annotations;

namespace CargaSinEstres.API.CargaSinEstres.Resources;

public class HiredCompanyResource
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [SwaggerSchema("Company Identifier")]
    public int Id { get; set; }

    [SwaggerSchema("Company Name")]
    public string Name { get; set; }

    [SwaggerSchema("Company Logo URL")]
    public string Logo { get; set; }
    
}
