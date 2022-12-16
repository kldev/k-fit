using System.Security.Claims;

namespace K.Fit.Api.Service.JwtService;

public interface IJwtTokenGenerator
{
    string GenerateJwtToken(string userId, Claim[] claims);
}