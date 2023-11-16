using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Repositories;
using CargaSinEstres.API.CargaSinEstres.Domain.Services;
using CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;

namespace CargaSinEstres.API.CargaSinEstres.Services;

public class BookingHistoryService : IBookingHistoryService
{
    private readonly IBookingHistoryRepository _bookingHistoryRepository;
    private readonly IChatService _chatService;
    private readonly IPaymentService _paymentService;

    public BookingHistoryService(IBookingHistoryRepository bookingHistoryRepository, IChatService chatService, IPaymentService paymentService)
    {
        _bookingHistoryRepository = bookingHistoryRepository;
        _chatService = chatService;
        _paymentService = paymentService;
    }

    public async Task<BookingHistory> GetBookingAsync(int id)
    {
        var booking = await _bookingHistoryRepository.GetAsync(id);
        if (booking != null)
        {
            booking.Chats = await _chatService.GetChatsAsync(); // Obtener los chats asociados
            booking.Payment = await _paymentService.GetPaymentAsync(booking.Payment.Id); // Obtener el pago asociado
        }
        return booking;
    }

    public async Task<IEnumerable<BookingHistory>> GetBookingHistoryAsync()
    {
        var bookings = await _bookingHistoryRepository.ListAsync();
        foreach (var booking in bookings)
        {
            booking.Chats = await _chatService.GetChatsAsync(); // Obtener los chats asociados
            booking.Payment = await _paymentService.GetPaymentAsync(booking.Payment.Id); // Obtener el pago asociado
        }
        return bookings;
    }

    public async Task<IEnumerable<BookingHistory>> GetBookingsByClientIdAsync(int clientId)
    {
        var bookings = await _bookingHistoryRepository.ListByClientIdAsync(clientId);
        foreach (var booking in bookings)
        {
            booking.Chats = await _chatService.GetChatsAsync(); // Obtener los chats asociados
            booking.Payment = await _paymentService.GetPaymentAsync(booking.Payment.Id); // Obtener el pago asociado
        }
        return bookings;
    }

    public async Task<IEnumerable<BookingHistory>> GetBookingsByCompanyIdAsync(int companyId)
    {
        var bookings = await _bookingHistoryRepository.ListByCompanyIdAsync(companyId);
        foreach (var booking in bookings)
        {
            booking.Chats = await _chatService.GetChatsAsync(); // Obtener los chats asociados
            booking.Payment = await _paymentService.GetPaymentAsync(booking.Payment.Id); // Obtener el pago asociado
        }
        return bookings;
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