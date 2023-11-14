namespace CargaSinEstres.API.CargaSinEstres.Domain.Models;

public class Worker
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int CompanyId { get; set; }

    //Relationships

    public List<Comment> Comments { get; set; } = new List<Comment>();
}