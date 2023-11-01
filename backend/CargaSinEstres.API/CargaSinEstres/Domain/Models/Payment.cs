namespace CargaSinEstres.API.CargaSinEstres.Domain.Models;

public class Payment{
    public int Id { get; set; }
    public float TotalAmount { get; set; }
    public string PaymentMethod { get; set; }
}