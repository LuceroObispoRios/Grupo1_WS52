using CargaSinEstres.API.CargaSinEstres.Security.Authorization.Handlers.Interfaces;
using CargaSinEstres.API.CargaSinEstres.Security.Authorization.Settings;
using CargaSinEstres.API.CargaSinEstres.Security.Domain.Services;
using Microsoft.Extensions.Options;

namespace CargaSinEstres.API.CargaSinEstres.Security.Authorization.Middleware;

public class JwtMiddleware
{
    private readonly RequestDelegate _next;
    private readonly AppSettings _appSettings;
    public JwtMiddleware(RequestDelegate next, IOptions<AppSettings> appSettings)
    {
        _next = next;
        _appSettings = appSettings.Value;;
    }
    public async Task Invoke(HttpContext context, ICompanyService
        companyService, IJwtHandler handler)
    {
        var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split("").Last();
        var companyId = handler.ValidateToken(token);
        if (companyId != null)
        { 
            // attach user to context on successful jwt validation
            context.Items["Company"] = await companyService.GetByIdAsync(companyId.Value);
        }
        await _next(context);
    }
}