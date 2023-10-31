using CargaSinEstres.API.CargaSinEstres.Security.Domain.Models;

namespace CargaSinEstres.API.CargaSinEstres.Security.Authorization.Handlers.Interfaces;

public interface IJwtHandler
{
    public string GenerateToken(Company company);
    public int? ValidateToken(string token);
}
