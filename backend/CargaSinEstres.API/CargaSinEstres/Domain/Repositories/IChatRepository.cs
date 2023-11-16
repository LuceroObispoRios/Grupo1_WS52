using CargaSinEstres.API.CargaSinEstres.Domain.Models;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Repositories;

public interface IChatRepository
{
    Task<IEnumerable<Chat>> ListAsync();
    Task<Chat> GetByIdAsync(int id);
    Task AddAsync(Chat chat);
    Task UpdateAsync(Chat chat);
    Task RemoveAsync(Chat chat);
}