namespace K.Fit.Api.Security;

public interface IPasswordHasher
{
    string Hash(string value);
    bool Match(string check, string hashed);
}