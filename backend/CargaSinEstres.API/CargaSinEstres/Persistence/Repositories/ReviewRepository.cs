using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Repositories;
using CargaSinEstres.API.CargaSinEstres.Shared.Persistence.Contexts;
using CargaSinEstres.API.CargaSinEstres.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CargaSinEstres.API.Shared.Persistence.Repositories;

public class ReviewRepository : BaseRepository, IReviewRepository {
    public ReviewRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Review>> ListAsync()
    {
        return await _context.Reviews.ToListAsync();
    }

    public async Task AddAsync(Review review)
    {
        await _context.Reviews.AddAsync(review);
    }
}