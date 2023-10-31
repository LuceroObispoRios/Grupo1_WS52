using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Repositories;
using CargaSinEstres.API.CargaSinEstres.Shared.Persistence.Contexts;
using CargaSinEstres.API.CargaSinEstres.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CargaSinEstres.API.Shared.Persistence.Repositories;

//public class ClientRepository : BaseRepository, IClientRepository
//{
    //public ClientRepository(AppDbContext context) : base(context)
    //{
    //}
    //public async Task<IEnumerable<Client>> ListAsync()
    //{
        //return await _context.Clients.ToListAsync();
    //}
    //public async Task AddAsync(Client client)
    //{
      //  await _context.Clients.AddAsync(client);
    //}
    //public async Task<Client> FindByIdAsync(int id)
    //{
      //  return await _context.Clients.FindAsync(id);
    //}
    //public void Update(Client client)
    //{
      //  _context.Clients.Update(client);
    //}
//}