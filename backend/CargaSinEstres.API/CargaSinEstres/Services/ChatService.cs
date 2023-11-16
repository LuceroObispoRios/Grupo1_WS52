using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Repositories;
using CargaSinEstres.API.CargaSinEstres.Domain.Services;
using CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;

namespace CargaSinEstres.API.CargaSinEstres.Services;

public class ChatService: IChatService
{
    private readonly IChatRepository _chatRepository;

    public ChatService(IChatRepository chatRepository)
    {
        _chatRepository = chatRepository;
    }

    public async Task<IEnumerable<Chat>> GetChatsAsync()
    {
        return await _chatRepository.ListAsync();
    }

    public async Task<Chat> GetChatAsync(int id)
    {
        return await _chatRepository.GetByIdAsync(id);
    }

    public async Task<ChatResponse> CreateChatAsync(Chat chat)
    {
        try
        {
            await _chatRepository.AddAsync(chat);
            return new ChatResponse(chat);
        }
        catch (Exception ex)
        {
            return new ChatResponse($"Error al crear el chat: {ex.Message}");
        }
    }

    public async Task<ChatResponse> UpdateChatAsync(int id, Chat chat)
    {
        var existingChat = await _chatRepository.GetByIdAsync(id);

        if (existingChat == null)
        {
            return new ChatResponse("Chat no encontrado.");
        }

        existingChat.User = chat.User;
        existingChat.Message = chat.Message;
        existingChat.DateTime = chat.DateTime;

        try
        {
            await _chatRepository.UpdateAsync(existingChat);
            return new ChatResponse(existingChat);
        }
        catch (Exception ex)
        {
            return new ChatResponse($"Error al actualizar el chat: {ex.Message}");
        }
    }

    public async Task<ChatResponse> DeleteChatAsync(int id)
    {
        var existingChat = await _chatRepository.GetByIdAsync(id);

        if (existingChat == null)
        {
            return new ChatResponse("Chat no encontrado.");
        }

        try
        {
            await _chatRepository.RemoveAsync(existingChat);
            return new ChatResponse(existingChat);
        }
        catch (Exception ex)
        {
            return new ChatResponse($"Error al eliminar el chat: {ex.Message}");
        }
    }
}