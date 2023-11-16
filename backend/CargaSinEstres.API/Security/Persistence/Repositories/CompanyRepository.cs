using CargaSinEstres.API.Shared.Persistence.Contexts;
using CargaSinEstres.API.Security.Domain.Repositories;
using CargaSinEstres.API.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CargaSinEstres.API.Security.Persistence.Repositories;

public class CompanyRepository :BaseRepository, ICompanyRepository
{
    public CompanyRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Domain.Models.Company>> ListAsync()
    {
        return await _context.Companies.ToListAsync();
    }

    public async Task AddAsync(Domain.Models.Company company)
    {
        await _context.Companies.AddAsync(company);
    }

    public async Task<Domain.Models.Company> FindByIdAsync(int id)
    {
        return await _context.Companies.FindAsync(id);
    }

    public async Task<Domain.Models.Company> FindByEmailAsync(string email)
    {
        return await _context.Companies.SingleOrDefaultAsync(x => x.Email == email);
    }

    public bool ExistsByEmail(string email)
    {
        return _context.Companies.Any(x => x.Email == email);
    }

    public Domain.Models.Company FindById(int id)
    {
        return _context.Companies.Find(id);
    }

    public void Update(Domain.Models.Company company)
    {
        _context.Companies.Update(company);
    }
}