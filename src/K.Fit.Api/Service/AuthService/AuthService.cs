using System.Security.Claims;
using K.Fit.Api.Config;
using K.Fit.Api.DAL;
using K.Fit.Api.Security;
using K.Fit.Api.Service.AuthService.Requests;
using K.Fit.Api.Service.AuthService.Responses;
using K.Fit.Api.Service.JwtService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace K.Fit.Api.Service.AuthService;

public class AuthService : IAuthService
{

    private readonly IHttpContextAccessor _contextAccessor;
    private readonly AppJwtConfig _jwtConfig;
    private readonly IJwtTokenGenerator _tokenGenerator;
    private readonly FitContext _fitContext;
    private readonly IPasswordHasher _passwordHasher;

    public AuthService(IHttpContextAccessor contextAccessor, IJwtTokenGenerator tokenGenerator, FitContext fitContext,
        IPasswordHasher passwordHasher, IOptions<AppJwtConfig> jwtConfig)
    {
        _contextAccessor = contextAccessor;
        _tokenGenerator = tokenGenerator;
        _fitContext = fitContext;
        _passwordHasher = passwordHasher;
        _jwtConfig = jwtConfig.Value;
    }

    public async Task<LoginResponse> LogInAsync(LoginRequest request)
    {
        if (string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Username))
        {
            throw new Exception("Invalid arguments");
        }

        var user = await _fitContext.Users.FirstOrDefaultAsync(x => x.Username == request.Username);

        if (user is null)
        {
            throw new Exception("User not found");
        }

        if (!_passwordHasher.Match(request.Password, user.Password))
        {
            throw new Exception("Username or password invalid");
        }

        var claims = new List<Claim>
        {
            new("username", user.Username)
        };

        var response = new LoginResponse
        {
            Token = _tokenGenerator.GenerateJwtToken(user.Gid.ToString(), claims.ToArray())
        };

        var cookieOptions = new CookieOptions
        {
            Domain = _jwtConfig.CookieDomain,
            Path = "/",
            SameSite = SameSiteMode.Strict,
            Secure = false,
            MaxAge = TimeSpan.FromDays(14),
            HttpOnly = true
        };

        if (_contextAccessor.HttpContext != null)
            _contextAccessor.HttpContext.Response.Cookies.Append(_jwtConfig.CookieName, response.Token,
                cookieOptions);

        return response;
    }
}