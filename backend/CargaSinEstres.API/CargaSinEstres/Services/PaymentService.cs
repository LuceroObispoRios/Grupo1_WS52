using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Repositories;
using CargaSinEstres.API.CargaSinEstres.Domain.Services;
using CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;

namespace CargaSinEstres.API.CargaSinEstres.Services;

public class PaymentService: IPaymentService
{
    private readonly IPaymentRepository _paymentRepository;

    public PaymentService(IPaymentRepository paymentRepository)
    {
        _paymentRepository = paymentRepository;
    }

    public async Task<IEnumerable<Payment>> GetPaymentsAsync()
    {
        return await _paymentRepository.ListAsync();
    }

    public async Task<Payment> GetPaymentAsync(int id)
    {
        return await _paymentRepository.GetByIdAsync(id);
    }

    public async Task<PaymentResponse> CreatePaymentAsync(Payment payment)
    {
        try
        {
            await _paymentRepository.AddAsync(payment);
            return new PaymentResponse(payment);
        }
        catch (Exception ex)
        {
            return new PaymentResponse($"Error al crear el pago: {ex.Message}");
        }
    }

    public async Task<PaymentResponse> UpdatePaymentAsync(int id, Payment payment)
    {
        var existingPayment = await _paymentRepository.GetByIdAsync(id);

        if (existingPayment == null)
        {
            return new PaymentResponse("Pago no encontrado.");
        }

        existingPayment.TotalAmount = payment.TotalAmount;
        existingPayment.PaymentMethod = payment.PaymentMethod;

        try
        {
            await _paymentRepository.UpdateAsync(existingPayment);
            return new PaymentResponse(existingPayment);
        }
        catch (Exception ex)
        {
            return new PaymentResponse($"Error al actualizar el pago: {ex.Message}");
        }
    }

    public async Task<PaymentResponse> DeletePaymentAsync(int id)
    {
        var existingPayment = await _paymentRepository.GetByIdAsync(id);

        if (existingPayment == null)
        {
            return new PaymentResponse("Pago no encontrado.");
        }

        try
        {
            await _paymentRepository.RemoveAsync(existingPayment);
            return new PaymentResponse(existingPayment);
        }
        catch (Exception ex)
        {
            return new PaymentResponse($"Error al eliminar el pago: {ex.Message}");
        }
    }
}