using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Resources;

namespace CargaSinEstres.API.Security.Resources;

/// <summary>
/// Resource for showing and obtaining company data
/// </summary>
public class CompanyResource
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Direccion { get; set; }
    public string Description { get; set; }
    public int AverageRating { get; set; }
    public IList<ReviewResource> Reviews { get; set; } = new List<ReviewResource>();
}