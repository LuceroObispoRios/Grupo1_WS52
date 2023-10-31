using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Services;

public interface IClientService{
    Task<IEnumerable<Client>> ListAsync();
    Task<ClientResponse> SaveAsync(Client client);
    Task<ClientResponse> UpdateAsync(int id, Client client);
}