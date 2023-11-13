using System.ComponentModel.DataAnnotations;

namespace CargaSinEstres.API.CargaSinEstres.Resources;

public class SaveReviewResource
{
    [Required]
    public int Rating { get; set; }

    [MinLength(10)]
    public string Comment { get; set; }
    
    [Required]
    public int companyId { get; set; }
}