namespace CargaSinEstres.API.Company.Authorization.Handlers.Interfaces;

public interface IJwtHandler
{
    public string GenerateToken(Domain.Models.Company company);
    public int? ValidateToken(string token);
}