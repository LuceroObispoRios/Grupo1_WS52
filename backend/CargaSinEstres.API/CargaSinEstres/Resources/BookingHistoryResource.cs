using System.ComponentModel.DataAnnotations.Schema;
using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace CargaSinEstres.API.CargaSinEstres.Resources;

public class BookingHistoryResource
{
    [SwaggerSchema("Booking Identifier")]
    public int Id { get; set; }

    [SwaggerSchema("Company Identifier")]
    public int IdCompany { get; set; }

    [SwaggerSchema("Client Identifier")]
    public int IdClient { get; set; }

    [SwaggerSchema("Booking Date")]
    public string BookingDate { get; set; }

    [SwaggerSchema("Pickup Address")]
    public string PickupAddress { get; set; }

    [SwaggerSchema("Destination Address")]
    public string DestinationAddress { get; set; }

    [SwaggerSchema("Moving Date")]
    public string MovingDate { get; set; }
    
    [SwaggerSchema("Moving Time")]
    public string movingTime {get; set;}

    [SwaggerSchema("Booking Status")]
    public string Status { get; set; }
    
    [SwaggerSchema("Payment")]
    public PaymentResource Payment { get; set; }
    
    [SwaggerSchema("HiredCompany")]
    public HiredCompanyResource HiredCompany { get; set; }
    
    [SwaggerSchema("Chats")]
    public List<Chat> Chats { get; set; }
    [SwaggerSchema("Workers")]
    public List<int> Workers { get; set; }
    
    
}