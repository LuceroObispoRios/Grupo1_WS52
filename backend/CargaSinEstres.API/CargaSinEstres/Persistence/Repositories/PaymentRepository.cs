using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Repositories;
using CargaSinEstres.API.Shared.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CargaSinEstres.API.CargaSinEstres.Persistence.Repositories;

public class PaymentRepository: IPaymentRepository
{
    private readonly AppDbContext _context;

    public PaymentRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Payment>> ListAsync()
    {
        return await _context.Payments.ToListAsync();
    }

    public async Task<Payment> GetByIdAsync(int id)
    {
        return await _context.Payments.FindAsync(id);
    }

    public async Task AddAsync(Payment payment)
    {
        await _context.Payments.AddAsync(payment);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Payment payment)
    {
        _context.Payments.Update(payment);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveAsync(Payment payment)
    {
        _context.Payments.Remove(payment);
        await _context.SaveChangesAsync();
    }
}