using AutoMapper;
using CargaSinEstres.API.CargaSinEstres.Security.Authorization.Attributes;
using CargaSinEstres.API.CargaSinEstres.Security.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Security.Domain.Services;
using CargaSinEstres.API.CargaSinEstres.Security.Domain.Services.Communication;
using CargaSinEstres.API.CargaSinEstres.Security.Resources;
using Microsoft.AspNetCore.Mvc;

namespace CargaSinEstres.API.CargaSinEstres.Security.Controllers;

[Authorize]
[ApiController]
[Route("/api/v1/[controller]")]
public class CompaniesController : ControllerBase
{
    private readonly ICompanyService _companyService;
    private readonly IMapper _mapper;
    
    public CompaniesController(ICompanyService companyService, IMapper mapper)
    {
        _companyService = companyService;
        _mapper = mapper;
    }
    
    [AllowAnonymous]
    [HttpPost("sign-in")]
    public async Task<IActionResult> Authenticate(AuthenticateRequest request)
    {
        var response = await _companyService.Authenticate(request);
        return Ok(response);
    }
    
    [AllowAnonymous]
    [HttpPost("sign-up")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        await _companyService.RegisterAsync(request);
        return Ok(new { message = "Registration successful" });
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var companies = await _companyService.ListAsync();
        var resources = _mapper.Map<IEnumerable<Company>,
            IEnumerable<CompanyResource>>(companies);
        return Ok(resources);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var company = await _companyService.GetByIdAsync(id);
        var resource = _mapper.Map<Company, CompanyResource>(company);
        return Ok(resource);
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateRequest request)
    {
        await _companyService.UpdateAsync(id, request);
        return Ok(new { message = "Company updated successfully" });
    }
}
