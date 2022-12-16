using System.Security.Claims;

namespace K.Fit.Api.Security;

public class KFitUserIdentity
{

    public Guid Gid { get; set; } = Guid.NewGuid();
    public string Username { get; set; } = string.Empty;

    public KFitUserIdentity() { }

    public KFitUserIdentity(ClaimsPrincipal principal)
    {
        if (principal.Claims.Any())
        {
            var enumerable = principal.Claims as Claim[] ?? principal.Claims.ToArray();
            Gid = Guid.Parse(enumerable.First(x => x.Type == "id").Value);
            Username = enumerable.First(x => x.Type == "username").Value;
        }
        else
        {
            throw new ArgumentException("Session expired");
        }
    }
}