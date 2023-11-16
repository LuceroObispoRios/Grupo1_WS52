namespace CargaSinEstres.API.CargaSinEstres.Domain.Models;

public class Comment
{
    public int Id { get; set; }
    public string CommentText { get; set; }

    // Clave foránea
    public int WorkerId { get; set; }
    public Worker Worker { get; set; }
}