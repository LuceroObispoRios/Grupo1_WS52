using CargaSinEstres.API.CargaSinEstres.Security.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Security.Domain.Repositories;
using CargaSinEstres.API.CargaSinEstres.Shared.Persistence.Contexts;
using CargaSinEstres.API.CargaSinEstres.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CargaSinEstres.API.CargaSinEstres.Security.Persistence.Repositories;

public class CompanyRepository :BaseRepository, ICompanyRepository
{
    public CompanyRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Company>> ListAsync()
    {
        return await _context.Companies.ToListAsync();
    }

    public async Task AddAsync(Company company)
    {
        await _context.Companies.AddAsync(company);
    }

    public async Task<Company> FindByIdAsync(int id)
    {
        return await _context.Companies.FindAsync(id);
    }

    public async Task<Company> FindByEmailAsync(string email)
    {
        return await _context.Companies.SingleOrDefaultAsync(x => x.Email == email);
    }

    public bool ExistsByEmail(string email)
    {
        return _context.Companies.Any(x => x.Email == email);
    }

    public Company FindById(int id)
    {
        return _context.Companies.Find(id);
    }

    public void Update(Company company)
    {
        _context.Companies.Update(company);
    }
}
