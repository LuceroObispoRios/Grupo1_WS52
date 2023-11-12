using CargaSinEstres.API.Security.Authorization.Handlers.Interfaces;
using CargaSinEstres.API.Security.Authorization.Settings;
using CargaSinEstres.API.Security.Domain.Services;
using Microsoft.Extensions.Options;

namespace CargaSinEstres.API.Security.Authorization.Middleware;

public class JwtMiddleware
{
    private readonly RequestDelegate _next;
    private readonly AppSettings _appSettings;
    public JwtMiddleware(RequestDelegate next, IOptions<AppSettings> appSettings)
    {
        _next = next;
        _appSettings = appSettings.Value;;
    }
    public async Task Invoke(HttpContext context, ICompanyService companyService, IJwtHandler handler, IClientService clientService)
    {
        var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split("").Last();
        var companyId = handler.ValidateToken(token);
        var clientId = handler.ValidateToken(token);
        if (companyId != null && clientId != null)
        { 
            // attach user to context on successful jwt validation
            context.Items["Company"] = await companyService.GetByIdAsync(companyId.Value);
            context.Items["Client"] = await clientService.GetByIdClientAsync(clientId.Value);
        }
        await _next(context);
    }
}