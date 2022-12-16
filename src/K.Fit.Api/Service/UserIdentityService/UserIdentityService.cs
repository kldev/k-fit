using K.Fit.Api.Security;

namespace K.Fit.Api.Service.UserIdentityService;

public class UserIdentityService : IUserIdentityService
{
    private readonly IHttpContextAccessor _contextAccessor;

    public UserIdentityService(IHttpContextAccessor contextAccessor)
    {
        _contextAccessor = contextAccessor;
    }

    public KFitUserIdentity AuthenticatedUser()
    {
        var claims = _contextAccessor.HttpContext?.User;

        if (claims is not null)
        {
            return new KFitUserIdentity(claims);
        }

        throw new ArgumentException("Session expired");
    }
}