using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Services;

public interface IReviewService{

    Task<IEnumerable<Review>> ListAsync();
    Task<ReviewResponse> SaveAsync(Review review);
}