using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Services;

public interface IChatService
{
    Task<IEnumerable<Chat>> GetChatsAsync();
    Task<Chat> GetChatAsync(int id);
    Task<ChatResponse> CreateChatAsync(Chat chat);
    Task<ChatResponse> UpdateChatAsync(int id, Chat chat);
    Task<ChatResponse> DeleteChatAsync(int id);
}