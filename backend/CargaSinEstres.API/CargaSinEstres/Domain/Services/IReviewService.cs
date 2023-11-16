using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;
using CargaSinEstres.API.CargaSinEstres.Resources;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Services;

public interface IReviewService{

    Task<IEnumerable<Review>> ListAsync();
    
    Task<IEnumerable<Review>> FindByCompanyIdAsync(int companyId);
    
    Task<ReviewResponse> SaveAsync(Review review);
}