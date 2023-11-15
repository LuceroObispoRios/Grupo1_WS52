using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Swashbuckle.AspNetCore.Annotations;

namespace CargaSinEstres.API.CargaSinEstres.Resources;

public class PaymentResource
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [SwaggerSchema("Payment Identifier")]
    public int Id { get; set; }

    [SwaggerSchema("Total Amount")]
    public float TotalAmount { get; set; }

    [SwaggerSchema("Payment Method")]
    public string PaymentMethod { get; set; }
    
}
