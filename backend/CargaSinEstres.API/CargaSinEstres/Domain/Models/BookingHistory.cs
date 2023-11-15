using System.ComponentModel.DataAnnotations.Schema;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Models;

public class BookingHistory
{
    public int Id { get; set; }

    public int IdCompany { get; set;}

    public int idClient { get; set;}

    public string bookingDate { get; set;}

    public string pickupAddress { get; set;}

    public string destinationAddress { get; set;}

    public string movingDate {get; set;}
    
    public string movingTime {get; set;}

    public string Status { get; set;}

    public Payment Payment { get; set; } = new Payment();

    public HiredCompany HiredCompany { get; set; } = new HiredCompany();
    
    public List<Chat> Chats { get; set; } = new List<Chat>();

    [NotMapped]
    public List<int> Workers { get; set; } = new List<int>();

}