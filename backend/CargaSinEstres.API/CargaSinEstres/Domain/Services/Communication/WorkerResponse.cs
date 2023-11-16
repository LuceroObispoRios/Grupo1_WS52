using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Shared.Domain.Services.Communication;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;

public class WorkerResponse : BaseResponse<Worker>
{
    public WorkerResponse(string message) : base(message)
    {
        
    }

    public WorkerResponse(Worker resource) : base(resource)
    {
        
    }
}