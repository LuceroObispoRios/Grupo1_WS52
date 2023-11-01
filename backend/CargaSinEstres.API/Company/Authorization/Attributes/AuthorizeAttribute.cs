using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CargaSinEstres.API.Company.Authorization.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]

public class AuthorizeAttribute : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    { 
        // If action is decorated with [AllowAnonymous] attribute
        var allowAnonymous =
            context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any(); 
        // Then skip authorization process
        if (allowAnonymous)
            return; 
        // Authorization process
        var company = (Domain.Models.Company)context.HttpContext.Items["Company"];
        //var client = (Client)context.HttpContext.Items["Client"];
        if (company == null)
            context.Result = new JsonResult(new { message = "Unauthorized"}) { StatusCode = StatusCodes.Status401Unauthorized };
    }
}