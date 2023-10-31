using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Shared.Domain.Services.Communication;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;
public class BookingHistoryResponse : BaseResponse<BookingHistory>{
   
    public BookingHistoryResponse(string message) : base(message)
    {
    }
    public BookingHistoryResponse(BookingHistory resource) : base(resource)
    {
    }

    
}