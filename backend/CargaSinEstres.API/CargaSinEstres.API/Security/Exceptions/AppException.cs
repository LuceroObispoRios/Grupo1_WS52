using System.Globalization;
using BCryptNet = BCrypt.Net.BCrypt;

namespace CargaSinEstres.API.CargaSinEstres.Security.Exceptions;

public class AppException : Exception
{
    public AppException() : base() {}
    public AppException(string message) : base(message) { }
    public AppException(string message, params object[] args) 
        : base(String.Format(CultureInfo.CurrentCulture, message, args))
    {
        
    }
}
