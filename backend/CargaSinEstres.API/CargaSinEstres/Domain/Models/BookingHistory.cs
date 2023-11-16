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
    //public Chat Chat { get; set; } = new Chat();
    public IEnumerable<Chat> Chats { get; set; } = new List<Chat>();


    public HiredCompany HiredCompany { get; set; } = new HiredCompany();
 
    [NotMapped]
    public List<int> Workers { get; set; } = new List<int>();

}