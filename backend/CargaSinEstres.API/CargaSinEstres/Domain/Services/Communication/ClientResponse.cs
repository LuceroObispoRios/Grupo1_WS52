using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Shared.Domain.Services.Communication;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;

public class ClientResponse : BaseResponse<Client>
{
    public ClientResponse(string message) : base(message)
    {
    }

    public ClientResponse(Client resource) : base(resource)
    {
    }
}