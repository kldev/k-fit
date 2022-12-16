using K.Fit.Api.Service.AuthService.Requests;
using K.Fit.Api.Service.AuthService.Responses;

namespace K.Fit.Api.Service.AuthService;

public interface IAuthService
{
    public Task<LoginResponse> LogInAsync(LoginRequest request);
}