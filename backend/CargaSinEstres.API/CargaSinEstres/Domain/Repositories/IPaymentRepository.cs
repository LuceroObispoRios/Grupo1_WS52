using CargaSinEstres.API.CargaSinEstres.Domain.Models;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Repositories;

public interface IPaymentRepository
{
    Task<IEnumerable<Payment>> ListAsync();
    Task<Payment> GetByIdAsync(int id);
    Task AddAsync(Payment payment);
    Task UpdateAsync(Payment payment);
    Task RemoveAsync(Payment payment);
}