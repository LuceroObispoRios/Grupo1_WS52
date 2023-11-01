using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Repositories;
using CargaSinEstres.API.CargaSinEstres.Domain.Services;
using CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;

namespace CargaSinEstres.API.CargaSinEstres.Services;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ClientService(IClientRepository clientRepository, IUnitOfWork unitOfWork)
    {
        _clientRepository = clientRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Client>> ListAsync()
    {
        return await _clientRepository.ListAsync();
    }

    public async Task<ClientResponse> SaveAsync(Client client)
    {
        try
        {
            await _clientRepository.AddAsync(client);
            await _unitOfWork.CompleteAsync();
            return new ClientResponse(client);
        }
        catch (Exception e)
        {
            return new ClientResponse($"An error occurred while saving the client: {e.Message}");
        }
    }
    
    public async Task<Client> GetByIdAsync(int id)
    {
        var client = await _clientRepository.FindByIdAsync(id);
        if (client == null) throw new KeyNotFoundException("Client not found");
        return client;
    }

    private Client GetById(int id)
    {
        var client = _clientRepository.FindById(id);
        if (client == null) throw new KeyNotFoundException("Client not found");
        return client;
    }
    
    public async Task<ClientResponse> UpdateAsync(int id, Client client)
    {
        var existingClient = await _clientRepository.FindByIdAsync(id);
        if (existingClient == null)
            return new ClientResponse("Client not found.");
        existingClient.Nombre = client.Nombre;
        try
        {
            _clientRepository.Update(existingClient);
            await _unitOfWork.CompleteAsync();
            return new ClientResponse(existingClient);
        }
        catch (Exception e)
        {
            return new ClientResponse($"An error occurred while updating the client:{e.Message}");
        }
    }
}