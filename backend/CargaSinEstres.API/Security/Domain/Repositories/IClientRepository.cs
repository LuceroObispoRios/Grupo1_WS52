using CargaSinEstres.API.Security.Domain.Models;

namespace CargaSinEstres.API.Security.Domain.Repositories;

public interface IClientRepository {
    Task<IEnumerable<Client>> ListClientAsync();
    Task AddClientAsync(Client client);
    Task<Client> FindByIdClientAsync(int id);
    Task<Client> FindByEmailClientAsync(string correo);
    public bool ExistsByEmailClient(string correo);
    Client FindByIdClient(int id);
    void UpdateClient(Client client);
}