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

    [SwaggerSchema("Booking Status")]
    public string Status { get; set; }
}