using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Repositories;
using CargaSinEstres.API.CargaSinEstres.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CargaSinEstres.API.Shared.Persistence.Repositories;
public class BookingHistoryRepository :BaseRepository, IBookingHistoryRepository
{
    private readonly AppDbContext _context;

    public BookingHistoryRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<BookingHistory> GetAsync(int id)
    {
        return await _context.BookingHistories.FindAsync(id);
    }

    public async Task<IEnumerable<BookingHistory>> ListAsync()
    {
        return await _context.BookingHistories.ToListAsync();
    }

    public async Task AddAsync(BookingHistory booking)
    {
        await _context.BookingHistories.AddAsync(booking);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(BookingHistory booking)
    {
        _context.BookingHistories.Update(booking);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveAsync(BookingHistory booking)
    {
        _context.BookingHistories.Remove(booking);
        await _context.SaveChangesAsync();
    }
}