using CargaSinEstres.API.Security.Resources;

namespace CargaSinEstres.API.CargaSinEstres.Resources;

public class WorkerResource
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int CompanyId { get; set; }
    public IList<CommentResource> Comments { get; set; } = new List<CommentResource>();
}