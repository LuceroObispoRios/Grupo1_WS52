using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Shared.Domain.Services.Communication;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;

public class PaymentResponse: BaseResponse<Payment>{
    public PaymentResponse(string message) : base(message)
    {
    }

    public PaymentResponse(Payment resource) : base(resource)
    {
    }
}