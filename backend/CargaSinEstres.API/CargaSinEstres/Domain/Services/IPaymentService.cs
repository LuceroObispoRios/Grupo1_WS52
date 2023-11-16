using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Services;

public interface IPaymentService
{
    Task<IEnumerable<Payment>> GetPaymentsAsync();
    Task<Payment> GetPaymentAsync(int id);
    Task<PaymentResponse> CreatePaymentAsync(Payment payment);
    Task<PaymentResponse> UpdatePaymentAsync(int id, Payment payment);
    Task<PaymentResponse> DeletePaymentAsync(int id);
}