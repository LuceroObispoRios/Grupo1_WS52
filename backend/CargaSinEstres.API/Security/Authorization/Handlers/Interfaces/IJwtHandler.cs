using CargaSinEstres.API.Security.Domain.Models;

namespace CargaSinEstres.API.Security.Authorization.Handlers.Interfaces;

public interface IJwtHandler
{
    public string GenerateToken(Company company);
    public string GenerateToken(Client client);
    public int? ValidateToken(string token);
}