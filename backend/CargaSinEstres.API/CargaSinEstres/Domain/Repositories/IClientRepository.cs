using CargaSinEstres.API.CargaSinEstres.Domain.Models;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Repositories;

public interface IClientRepository {
    Task<IEnumerable<Client>> ListAsync();
    Task<Client> FindByIdAsync(int id);
    Task AddAsync(Client client);
    Client FindById(int id);
    void Update(Client client);
}