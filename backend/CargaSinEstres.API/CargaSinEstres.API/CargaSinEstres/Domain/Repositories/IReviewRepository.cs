using CargaSinEstres.API.CargaSinEstres.Domain.Models;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Repositories;

public interface IReviewRepository {

    Task<IEnumerable<Review>> ListAsync();
    Task AddAsync(Review review);
}