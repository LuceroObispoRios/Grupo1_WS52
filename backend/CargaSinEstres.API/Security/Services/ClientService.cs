using AutoMapper;
using CargaSinEstres.API.CargaSinEstres.Domain.Repositories;
using CargaSinEstres.API.Security.Authorization.Handlers.Interfaces;
using CargaSinEstres.API.Security.Domain.Models;
using CargaSinEstres.API.Security.Domain.Repositories;
using CargaSinEstres.API.Security.Domain.Services;
using CargaSinEstres.API.Security.Domain.Services.Communication;
using CargaSinEstres.API.Security.Exceptions;
using IClientRepository = CargaSinEstres.API.Security.Domain.Repositories.IClientRepository;

namespace CargaSinEstres.API.Security.Services;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IJwtHandler _jwtHandlerClient;
    private readonly IMapper _mapper;

    public ClientService(IClientRepository clientRepository, IUnitOfWork unitOfWork, IJwtHandler jwtHandlerClient, IMapper mapper)
    {
        _clientRepository = clientRepository;
        _unitOfWork = unitOfWork;
        _jwtHandlerClient = jwtHandlerClient;
        _mapper = mapper;
    }

    public ClientService(IClientRepository clientRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _clientRepository = clientRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<AuthenticateResponseClient> AuthenticateClient(AuthenticateRequestClient request)
    {
        var client = await _clientRepository.FindByEmailClientAsync(request.Correo);
        Console.WriteLine($"Request: {request.Correo},{request.Contraseña}");
        Console.WriteLine($"Client: {client.Id}, {client.Correo}, {client.Contraseña}");
        Console.WriteLine("Authentication successful. About to generate token");
        // authentication successful
        var response = _mapper.Map<AuthenticateResponseClient>(client);
        Console.WriteLine($"Response: {response.Id}, {response.Correo}");
        return response;
    }
    
    public async Task<IEnumerable<Client>> ListClientAsync()
    {
        return await _clientRepository.ListClientAsync();
    }

    public async Task<Client> GetByIdClientAsync(int id)
    {
        var client = await _clientRepository.FindByIdClientAsync(id);
        if (client == null) throw new KeyNotFoundException("Client not found");
        return client;
    }
    
    public async Task RegisterClientAsync(RegisterRequestClient request)
    { 
        // validate
        if (_clientRepository.ExistsByEmailClient(request.Correo))
            throw new AppException("Email: '" + request.Correo + "' is already taken");
        var client = _mapper.Map<Client>(request); 
        try
        {
            await _clientRepository.AddClientAsync(client);
            await _unitOfWork.CompleteAsync();
        }
        catch (Exception e)
        {
            throw new AppException($"An error occurred while saving the client: {e.Message}");
        }
    }
    
    // helper methods
    private Client GetByIdClient(int id)
    {
        var client = _clientRepository.FindByIdClient(id);
        if (client == null) throw new KeyNotFoundException("Client not found");
        return client;
    }
    
    public async Task UpdateClientAsync(int id, UpdateRequestClient request)
    {
        var client = GetByIdClient(id);
        // Validate
        if (_clientRepository.ExistsByEmailClient(request.Correo))
            throw new AppException("Email: '" + request.Correo + "' is already taken");
        _mapper.Map(request, client);
        try
        {
            _clientRepository.UpdateClient(client);
            await _unitOfWork.CompleteAsync();
        }
        catch (Exception e)
        {
            throw new AppException($"An error occurred while updating the client: {e.Message}");
        }
    }
}