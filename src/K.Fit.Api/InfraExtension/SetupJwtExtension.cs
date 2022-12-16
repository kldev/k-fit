using System.Text;
using K.Fit.Api.Config;
using K.Fit.Api.Service.JwtService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace K.Fit.Api.InfraExtension;

public static class SetupJwtExtension
{
    public static WebApplicationBuilder SetupJwt(this WebApplicationBuilder builder)
    {
        var config = new AppJwtConfig()
        {
            Secret = builder.Configuration[$"{nameof(AppJwtConfig)}:{nameof(AppJwtConfig.Secret)}"],
            Issuer = builder.Configuration[$"{nameof(AppJwtConfig)}:{nameof(AppJwtConfig.Issuer)}"],
            CookieName = builder.Configuration[$"{nameof(AppJwtConfig)}:{nameof(AppJwtConfig.CookieName)}"],
            CookieDomain = builder.Configuration[$"{nameof(AppJwtConfig)}:{nameof(AppJwtConfig.CookieDomain)}"]
        };

        builder.Services.Configure<AppJwtConfig>(builder.Configuration.GetSection(nameof(AppJwtConfig)));
        builder.Services.AddTransient<IJwtTokenGenerator, JwtTokenGenerator>();

        if (!config.IsValid) throw new ArgumentException("Check config JwtConfig -> Secret, Issuer");
        //builder.Services.AddAuthorization();
        builder.Services.AddAuthentication(x =>
        {
            x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.RequireHttpsMetadata = false;
            options.SaveToken = true;
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(config.Secret)),
                ValidIssuer = config.Issuer,
                ValidateIssuer = false,
                ValidateAudience = false,
                RequireExpirationTime = true,
                ClockSkew = TimeSpan.Zero
            };

            options.Events = new JwtBearerEvents
            {
                OnMessageReceived = context =>
                {
                    if (context.Request.Headers.ContainsKey("Authorization"))
                    {
                        context.Token = context.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
                        return Task.CompletedTask;
                    }

                    if (context.Request.Cookies[config.CookieName] != null)
                    {
                        Console.WriteLine($"Setup JWT from cookie: {context.Request.Cookies[config.CookieName]}");
                        context.Token = context.Request.Cookies[config.CookieName];
                    }

                    return Task.CompletedTask;
                }
            };
        });

        builder.Services.AddAuthorization();

        return builder;
    }
}