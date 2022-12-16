using K.Fit.Api.DAL;
using K.Fit.Api.InfraExtension;
using K.Fit.Api.Security;
using K.Fit.Api.Service.AuthService;
using K.Fit.Api.Service.AuthService.Requests;
using K.Fit.Api.Service.UserIdentityService;
using K.Fit.Api.Service.WorkoutService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace K.Fit.Api;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddTransient<IPasswordHasher, BCryptPasswordHasher>();

        builder.Services.AddDbContext<FitContext>(opt =>
            opt.UseNpgsql(builder.Configuration.GetConnectionString("FitConn"),
                sqlOpt => { sqlOpt.MigrationsAssembly("K.Fit.Api"); }));

        builder.Services.AddScoped<IUserIdentityService, UserIdentityService>();
        builder.Services.AddScoped<IAuthService, AuthService>();
        builder.Services.AddScoped<IWorkoutService, WorkoutService>();
        builder.SetupJwt();
        builder.Services.AddHttpContextAccessor();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        using (var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            var context = services.GetRequiredService<FitContext>();
            await context.Database.EnsureDeletedAsync();
            await context.Database.EnsureCreatedAsync();
            //await context.Database.MigrateAsync();

            SeedService.Initialize(services);
        }

        app.UseSwagger();
        app.UseSwaggerUI();
        app.UseAuthentication();
        app.UseAuthorization();

        app.MapGet("/api/ping", 
            () => "pong"
            ).WithName("ping").AllowAnonymous();

        app.MapPost("/api/loginJWT", 
            (IAuthService service,
                [FromBody]LoginRequest request) => service.LogInAsync(request)
            ).WithName("Login JWT").AllowAnonymous();
        
        app.MapGet("/api/summary", 
            (IWorkoutService service, IUserIdentityService identityService ) => service.GetSummaryAsync(identityService.AuthenticatedUser().Gid)
            ).WithName("Get Summary").RequireAuthorization();
        
        app.MapGet("/api/summary-ef", 
            (IWorkoutService service, IUserIdentityService identityService ) => service.GetSummaryEFAsync(identityService.AuthenticatedUser().Gid)
            ).WithName("Get EF Summary").RequireAuthorization();

        await app.RunAsync();
    }
}
