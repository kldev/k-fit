using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using K.Fit.Api.Config;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace K.Fit.Api.Service.JwtService;

public class JwtTokenGenerator : IJwtTokenGenerator
{
    private readonly AppJwtConfig _config;

    public JwtTokenGenerator(IOptions<AppJwtConfig> jwtConfig)
    {
        _config = jwtConfig.Value;
        if (!_config.IsValid) throw new ArgumentException("Can not setup JwtTokenGenerator");
    }

    public string GenerateJwtToken(string userId, Claim[] claims)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.Secret));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var setupClaims = new List<Claim>();
        if (claims.Length == 0 || claims.All(x => x.Type != "id")) setupClaims.Add(new Claim("id", userId));

        setupClaims.AddRange(claims);

        var jwtToken = new JwtSecurityToken(
            _config.Issuer,
            null,
            setupClaims,
            expires: DateTime.UtcNow.AddDays(14),
            signingCredentials: credentials
        );
        var token = new JwtSecurityTokenHandler().WriteToken(jwtToken);
        return token;
    }
}