using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using CargaSinEstres.API.Security.Authorization.Handlers.Interfaces;
using CargaSinEstres.API.Security.Authorization.Settings;
using CargaSinEstres.API.Security.Domain.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace CargaSinEstres.API.Security.Authorization.Handlers.Implementations;

public class JwtHandlerClient : IJwtHandler
{
     private readonly AppSettings _appSettings;
    
    public JwtHandlerClient(IOptions<AppSettings> appSettings)
    {
        _appSettings = appSettings.Value;
    }

    public string GenerateToken(Company company)
    {
        throw new NotImplementedException();
    }

    public string GenerateToken(Client client)
    {
        // Generate Token for a valid period of 7 days
        var tokenHandler = new JwtSecurityTokenHandler();
        Console.WriteLine($"token handler: {tokenHandler.TokenType}");
        var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
        Console.WriteLine($"Secret Key: {key}");
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Sid, client.Id.ToString()),
                new Claim(ClaimTypes.Name, client.Correo)
            }),
            Expires = DateTime.UtcNow.AddDays(7),
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        Console.WriteLine($"token: {token.Id}, {token.Issuer},{token.SecurityKey?.ToString()}");
        return tokenHandler.WriteToken(token);
    }
    
    public int? ValidateToken(string token)
    {
        if (string.IsNullOrEmpty(token))
            return null;

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_appSettings.Secret);

        // Execute Token validation

        try
        {
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                // Expiration with no delay
                ClockSkew = TimeSpan.Zero
            }, out var validatedToken);

            var jwtToken = (JwtSecurityToken)validatedToken;
            var clientId = int.Parse(jwtToken.Claims.First(claim => claim.Type == ClaimTypes.Sid).Value);

            return clientId;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }
}