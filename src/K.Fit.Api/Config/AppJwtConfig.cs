namespace K.Fit.Api.Config;

public record AppJwtConfig
{
    public string Secret { get; set; } = string.Empty;
    public string Issuer { get; set; } = string.Empty;
    public string CookieName { get; set; } = string.Empty;
    public string CookieDomain { get; set; } = string.Empty;
    public bool IsValid => !string.IsNullOrEmpty(Secret) && !string.IsNullOrEmpty(Issuer);
}