using System.ComponentModel.DataAnnotations;
namespace DefaultNamespace;

public class SaveBookingHistoryResource
{
    [Required]
    public int IdCompany { get; set; }

    [Required]
    public int IdClient { get; set; }

    [Required]
    public string BookingDate { get; set; }

    [Required]
    public string PickupAddress { get; set; }

    [Required]
    public string DestinationAddress { get; set; }

    [Required]
    public string MovingDate { get; set; }

    [Required]
    public string Status { get; set; }
}