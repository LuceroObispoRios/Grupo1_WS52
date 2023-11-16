using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Repositories;
using CargaSinEstres.API.Shared.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CargaSinEstres.API.CargaSinEstres.Persistence.Repositories;

public class ChatRepository: IChatRepository
{
    private readonly AppDbContext _context;

    public ChatRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Chat>> ListAsync()
    {
        return await _context.Chats.ToListAsync();
    }

    public async Task<Chat> GetByIdAsync(int id)
    {
        return await _context.Chats.FindAsync(id);
    }

    public async Task AddAsync(Chat chat)
    {
        await _context.Chats.AddAsync(chat);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Chat chat)
    {
        _context.Chats.Update(chat);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveAsync(Chat chat)
    {
        _context.Chats.Remove(chat);
        await _context.SaveChangesAsync();
    }
}