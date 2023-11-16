using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Repositories;
using CargaSinEstres.API.Shared.Persistence.Contexts;
using CargaSinEstres.API.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CargaSinEstres.API.CargaSinEstres.Persistence.Repositories;

public class WorkerRepository : BaseRepository, IWorkerRepository
{
    public WorkerRepository(AppDbContext context) : base(context) {}

    public async Task<Worker> FindByIdAsync(int id)
    {
        return await _context.Workers
            .Include(c => c.Comments) // Si deseas cargar también los comentarios
            .SingleOrDefaultAsync(c => c.Id == id);
    }


    
    public void Update(Worker worker)
    {
        _context.Workers.Update(worker);
    }
    
}