using CargaSinEstres.API.Security.Domain.Models;
using CargaSinEstres.API.Security.Domain.Services.Communication;

namespace CargaSinEstres.API.Security.Domain.Services;

public interface IClientService{
    Task<AuthenticateResponseClient> AuthenticateClient(AuthenticateRequestClient model);
    Task<IEnumerable<Client>> ListClientAsync();
    Task<Client> GetByIdClientAsync(int id);
    Task RegisterClientAsync(RegisterRequestClient model);
    Task UpdateClientAsync(int id, UpdateRequestClient model);
}