using CargaSinEstres.API.CargaSinEstres.Security.Domain.Models;

namespace CargaSinEstres.API.CargaSinEstres.Security.Domain.Repositories;

public interface ICompanyRepository
{
    Task<IEnumerable<Company>> ListAsync();
    Task AddAsync(Company company);
    Task<Company> FindByIdAsync(int id);
    Task<Company> FindByEmailAsync(string email);
    public bool ExistsByEmail(string email);
    Company FindById(int id);
    void Update(Company company);
}
