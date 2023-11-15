using CargaSinEstres.API.Security.Domain.Models;
using CargaSinEstres.API.Security.Domain.Repositories;
using CargaSinEstres.API.Shared.Persistence.Contexts;
using CargaSinEstres.API.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CargaSinEstres.API.Security.Persistence.Repositories;

public class ClientRepository : BaseRepository, IClientRepository
{
    public ClientRepository(AppDbContext context) : base(context)
    {
    }
    public async Task<IEnumerable<Client>> ListClientAsync()
    {
        return await _context.Clients.ToListAsync();
    }
    public async Task AddClientAsync(Client client)
    {
        await _context.Clients.AddAsync(client);
    }
    public async Task<Client> FindByIdClientAsync(int id)
    {
       return await _context.Clients.FindAsync(id);
    }
    public async Task<Client> FindByEmailClientAsync(string correo)
    {
        return await _context.Clients.SingleOrDefaultAsync(x => x.Correo == correo);
    }
    public bool ExistsByEmailClient(string correo)
    {
        return _context.Clients.Any(x => x.Correo == correo);
    }

    public Client FindByIdClient(int id)
    {
        return _context.Clients.Find(id);
    }

    public void UpdateClient(Client client)
    {
        _context.Clients.Update(client);
    }
}