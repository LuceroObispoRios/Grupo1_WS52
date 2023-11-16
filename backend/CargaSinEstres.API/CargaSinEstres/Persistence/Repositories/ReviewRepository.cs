using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Repositories;
using CargaSinEstres.API.CargaSinEstres.Resources;
using CargaSinEstres.API.Shared.Persistence.Contexts;
using CargaSinEstres.API.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CargaSinEstres.API.CargaSinEstres.Persistence.Repositories;

public class ReviewRepository : BaseRepository, IReviewRepository {
    public ReviewRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Review>> ListAsync()
    {
        return await _context.Reviews.ToListAsync();
    }
    
    public async Task<IEnumerable<Review>> FindByCompanyIdAsync(int companyId)
    {
        return await _context.Reviews
            .Where(p => p.CompanyId == companyId)
            .ToListAsync();
    }

    public async Task AddAsync(Review review)
    {
        await _context.Reviews.AddAsync(review);
    }
}