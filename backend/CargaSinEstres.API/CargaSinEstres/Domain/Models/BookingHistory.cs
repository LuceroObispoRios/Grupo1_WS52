namespace CargaSinEstres.API.CargaSinEstres.Domain.Models;

public class BookingHistory
{
    public int Id { get; set; }

    public int IdCompany { get; set;}

    public int idClient { get; set;}

    public string bookingDate { get; set;}

    public string pickupAdress { get; set;}

    public string destinationAdress { get; set;}

    public string movingDate {get; set;}

    public string Status { get; set;}

    public Payment Payment {get; set;}

    public HiredCompany HiredCompany { get; set;}

    public IList<Chat> Chats { get; set;} = new List<Chat>();

}