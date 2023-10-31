using System.Net;
using CargaSinEstres.API.CargaSinEstres.Security.Exceptions;

namespace CargaSinEstres.API.CargaSinEstres.Security.Authorization.Middleware;

public class ErrorHandlerMiddleware
{
    private readonly RequestDelegate _next;
    public ErrorHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception error)
        {
            var response = context.Response;
            switch(error)
            {
                case AppException e: 
                    // custom application error
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;
                case KeyNotFoundException e: 
                    // not found error
                    response.StatusCode = (int)HttpStatusCode.NotFound;
                    break;
                default: 
                    // unhandled error
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    break;
            }
        }
    }
}
