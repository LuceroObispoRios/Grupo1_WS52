using CargaSinEstres.API.Company.Domain.Services.Communication;

namespace CargaSinEstres.API.Company.Domain.Services;

public interface ICompanyService
{
    Task<AuthenticateResponse> Authenticate(AuthenticateRequest model);
    Task<IEnumerable<Models.Company>> ListAsync();
    Task<Models.Company> GetByIdAsync(int id);
    Task RegisterAsync(RegisterRequest model);
    Task UpdateAsync(int id, UpdateRequest model);
}