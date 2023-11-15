
using CargaSinEstres.API.Security.Resources;

namespace CargaSinEstres.API.CargaSinEstres.Resources;

public class ReviewResource
{
    public int Id { get; set; }

    public int Rating { get; set; }

    public string Comment { get; set; }
    
    
    
    //public CompanyResource Company { get; set; }
}