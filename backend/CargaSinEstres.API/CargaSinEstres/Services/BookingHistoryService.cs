using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Repositories;
using CargaSinEstres.API.CargaSinEstres.Domain.Services;
using CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;

namespace CargaSinEstres.API.CargaSinEstres.Services;

public class BookingHistoryService : IBookingHistoryService
{
    private readonly IBookingHistoryRepository _bookingHistoryRepository;

    public BookingHistoryService(IBookingHistoryRepository bookingHistoryRepository)
    {
        _bookingHistoryRepository = bookingHistoryRepository;
    }

    public async Task<BookingHistory> GetBookingAsync(int id)
    {
        return await _bookingHistoryRepository.GetAsync(id);
    }

    public async Task<IEnumerable<BookingHistory>> GetBookingHistoryAsync()
    {
        return await _bookingHistoryRepository.ListAsync();
    }

    public async Task<BookingHistoryResponse> CreateBookingAsync(BookingHistory booking)
    {
        try
        {
            await _bookingHistoryRepository.AddAsync(booking);
            return new BookingHistoryResponse(booking);
        }
        catch (Exception ex)
        {
            return new BookingHistoryResponse($"Error al crear la reserva: {ex.Message}");
        }
    }

    public async Task<BookingHistoryResponse> UpdateBookingAsync(int id, BookingHistory booking)
    {
        var existingBooking = await _bookingHistoryRepository.GetAsync(id);

        if (existingBooking == null)
        {
            return new BookingHistoryResponse("Reserva no encontrada.");
        }

        existingBooking.Status = booking.Status; 

        try
        {
            await _bookingHistoryRepository.UpdateAsync(existingBooking);
            return new BookingHistoryResponse(existingBooking);
        }
        catch (Exception ex)
        {
            return new BookingHistoryResponse($"Error al actualizar la reserva: {ex.Message}");
        }
    }

    public async Task<BookingHistoryResponse> DeleteBookingAsync(int id)
    {
        var existingBooking = await _bookingHistoryRepository.GetAsync(id);

        if (existingBooking == null)
        {
            return new BookingHistoryResponse("Reserva no encontrada.");
        }

        try
        {
            await _bookingHistoryRepository.RemoveAsync(existingBooking);
            return new BookingHistoryResponse(existingBooking);
        }
        catch (Exception ex)
        {
            return new BookingHistoryResponse($"Error al eliminar la reserva: {ex.Message}");
        }
    }
}