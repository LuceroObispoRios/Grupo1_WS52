namespace CargaSinEstres.API.CargaSinEstres.Domain.Models;

//using the namespace of the company model
public class Review{
    public int Id { get; set; }

    public int Rating { get; set; }

    public string Comment { get; set; }
    
    public int CompanyId { get; set; }
    
    public Security.Domain.Models.Company Company { get; set; }
    
}