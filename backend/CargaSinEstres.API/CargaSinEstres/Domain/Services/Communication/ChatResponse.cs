using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Shared.Domain.Services.Communication;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;

public class ChatResponse: BaseResponse<Chat>{
    public ChatResponse(string message) : base(message)
    {
    }

    public ChatResponse(Chat resource) : base(resource)
    {
    }
}