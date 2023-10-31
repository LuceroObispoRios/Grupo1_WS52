using CargaSinEstres.API.CargaSinEstres.Security.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Security.Domain.Services.Communication;

namespace CargaSinEstres.API.CargaSinEstres.Security.Domain.Services;

public interface ICompanyService
{
    Task<AuthenticateResponse> Authenticate(AuthenticateRequest model);
    Task<IEnumerable<Company>> ListAsync();
    Task<Company> GetByIdAsync(int id);
    Task RegisterAsync(RegisterRequest model);
    Task UpdateAsync(int id, UpdateRequest model);
}
