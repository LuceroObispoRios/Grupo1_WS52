using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Shared.Domain.Services.Communication;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;

public class ReviewResponse : BaseResponse<Review>{
    public ReviewResponse(string message) : base(message)
    {
    }

    public ReviewResponse(Review resource) : base(resource)
    {
    }
}