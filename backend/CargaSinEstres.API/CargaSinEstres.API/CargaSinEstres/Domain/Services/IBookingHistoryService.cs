using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Services;

public interface IBookingHistoryService{
    Task<BookingHistory> GetBookingAsync(int id);
    Task<IEnumerable<BookingHistory>> GetBookingHistoryAsync();
    Task<BookingHistoryResponse> CreateBookingAsync(BookingHistory booking);
    Task<BookingHistoryResponse> UpdateBookingAsync(int id, BookingHistory booking);
    Task<BookingHistoryResponse> DeleteBookingAsync(int id);
}