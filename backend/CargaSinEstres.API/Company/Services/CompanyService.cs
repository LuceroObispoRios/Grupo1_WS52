using AutoMapper;
using CargaSinEstres.API.CargaSinEstres.Domain.Repositories;
using CargaSinEstres.API.Company.Authorization.Handlers.Interfaces;
using CargaSinEstres.API.Company.Domain.Services;
using CargaSinEstres.API.Company.Domain.Services.Communication;
using CargaSinEstres.API.Company.Exceptions;
using BCryptNet = BCrypt.Net.BCrypt;
using ICompanyRepository = CargaSinEstres.API.Company.Domain.Repositories.ICompanyRepository;

namespace CargaSinEstres.API.Company.Services;

public class CompanyService : ICompanyService
{
    private readonly ICompanyRepository _companyRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IJwtHandler _jwtHandler;
    private readonly IMapper _mapper;
    public CompanyService(ICompanyRepository companyRepository, IUnitOfWork unitOfWork, IJwtHandler jwtHandler, IMapper mapper)
    {
        _companyRepository = companyRepository;
        _unitOfWork = unitOfWork;
        _jwtHandler = jwtHandler;
        _mapper = mapper;
    }

    public CompanyService(ICompanyRepository companyRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _companyRepository = companyRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<AuthenticateResponse> Authenticate(AuthenticateRequest request)
    {
        var company = await
            _companyRepository.FindByEmailAsync(request.Email);
        Console.WriteLine($"Request: {request.Email},{request.Password}");
        Console.WriteLine($"Company: {company.Id}, {company.Email}, {company.Password}");
        // validate
        /*if (company == null || !BCryptNet.Verify(request.Password,
                company.Password))
        {
            Console.WriteLine("Authentication Error");
            throw new AppException("Email or password is incorrect");
        }*/
        Console.WriteLine("Authentication successful. About to generate token");
        // authentication successful
        var response = _mapper.Map<AuthenticateResponse>(company);
        Console.WriteLine($"Response: {response.Id}, {response.Email}");
        /*response.Token = _jwtHandler.GenerateToken(company);
        Console.WriteLine($"Generated token is {response.Token}");*/
        return response;
    }

    public async Task<IEnumerable<Domain.Models.Company>> ListAsync()
    {
        return await _companyRepository.ListAsync();
    }
    
    public async Task<Domain.Models.Company> GetByIdAsync(int id)
    {
        var company = await _companyRepository.FindByIdAsync(id);
        if (company == null) throw new KeyNotFoundException("Company not found");
        return company;
    }
    
    public async Task RegisterAsync(RegisterRequest request)
    { 
        // validate
        if (_companyRepository.ExistsByEmail(request.Email))
            throw new AppException("Email: '" + request.Email + "' is already taken"); 
        // map model to new company object
        var company = _mapper.Map<Domain.Models.Company>(request); 
        // hash password
        //company.Password = BCryptNet.HashPassword(request.Password); 
        // save company
        try
        {
            await _companyRepository.AddAsync(company);
            await _unitOfWork.CompleteAsync();
        }
        catch (Exception e)
        {
            throw new AppException($"An error occurred while saving the company: {e.Message}");
        }
    }
    
    // helper methods
    private Domain.Models.Company GetById(int id)
    {
        var company = _companyRepository.FindById(id);
        if (company == null) throw new KeyNotFoundException("Company not found");
        return company;
    }
    
    public async Task UpdateAsync(int id, UpdateRequest request)
    {
        var company = GetById(id);
        // Validate
        if (_companyRepository.ExistsByEmail(request.Email))
            throw new AppException("Email: '" + request.Email + "' is already taken");
        // Hash password if it was entered
        //if (!string.IsNullOrEmpty(request.Password))
          //  company.Password = BCryptNet.HashPassword(request.Password);
        // Copy model to company and save
        _mapper.Map(request, company);
        try
        {
            _companyRepository.Update(company);
            await _unitOfWork.CompleteAsync();
        }
        catch (Exception e)
        {
            throw new AppException($"An error occurred while updating the company: {e.Message}");
        }
    }
}