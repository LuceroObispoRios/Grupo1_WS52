using CargaSinEstres.API.CargaSinEstres.Domain.Models;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Repositories;

public interface IBookingHistoryRepository {
    Task<BookingHistory> GetAsync(int id);
    Task<IEnumerable<BookingHistory>> ListAsync();
    Task<IEnumerable<BookingHistory>> ListByClientIdAsync(int clientId);
    Task<IEnumerable<BookingHistory>> ListByCompanyIdAsync(int clientId);
    Task AddAsync(BookingHistory booking);
    Task UpdateAsync(BookingHistory booking);
    Task RemoveAsync(BookingHistory booking);
}
