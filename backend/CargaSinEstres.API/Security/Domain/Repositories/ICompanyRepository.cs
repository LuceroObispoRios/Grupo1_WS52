namespace CargaSinEstres.API.Security.Domain.Repositories;

public interface ICompanyRepository
{
    Task<IEnumerable<Models.Company>> ListAsync();
    Task AddAsync(Models.Company company);
    Task<Models.Company> FindByIdAsync(int id);
    Task<Models.Company> FindByEmailAsync(string email);
    public bool ExistsByEmail(string email);
    Models.Company FindById(int id);
    void Update(Models.Company company);
}