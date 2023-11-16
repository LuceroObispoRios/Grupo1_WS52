using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;
using CargaSinEstres.API.CargaSinEstres.Resources;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Services;

public interface IWorkerService
{
    Task<WorkerResponse> UpdateCommentsAsync(int id, UpdateCommentResource updateCommentResource);

    Task<Worker> ListByWorkerIdAsync(int workerId);
}