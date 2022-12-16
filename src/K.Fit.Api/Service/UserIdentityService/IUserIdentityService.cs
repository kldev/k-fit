using K.Fit.Api.Security;

namespace K.Fit.Api.Service.UserIdentityService;

public interface IUserIdentityService
{
    public KFitUserIdentity AuthenticatedUser();
}