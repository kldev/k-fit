using K.Fit.Api.DAL;
using K.Fit.Api.InfraExtension;
using K.Fit.Api.Security;
using K.Fit.Api.Service.AuthService;
using K.Fit.Api.Service.AuthService.Requests;
using K.Fit.Api.Service.FileService;
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

        builder.Services.Configure<MinioConfig>(builder.Configuration.GetSection(MinioConfig.TAG_NAME));

        builder.Services.AddScoped<IUserIdentityService, UserIdentityService>();
        builder.Services.AddScoped<IFileService, FileService>();
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

        app.MapGet("/api/ping", (HttpContext httpContext) => "pong")
        .WithName("ping");

        app.MapPost("/api/loginJWT",
            (IAuthService service,
                [FromBody] LoginRequest request) => service.LogInAsync(request)
        ).WithName("Login JWT").AllowAnonymous();

        app.MapGet("/api/summary",
            (IWorkoutService service, IUserIdentityService identityService) => service.GetSummaryAsync(identityService.AuthenticatedUser().Gid)
        ).WithName("Get Summary").RequireAuthorization();

        app.MapGet("/api/summary-ef",
            (IWorkoutService service, IUserIdentityService identityService) => service.GetSummaryEFAsync(identityService.AuthenticatedUser().Gid)
        ).WithName("Get EF Summary").RequireAuthorization();

        app.MapGet("/api/kilos-summary", (IWorkoutService service, IUserIdentityService identityService) => service.GetKilosSummaryAsync(identityService.AuthenticatedUser().Gid)).WithName("Get Kilos Summary");

        app.Map("/", () => "K");

        app.MapPost("/api/workout-file/{gid:guid}", async (HttpContext context, FitContext db, IFileService fileService) =>
        {
            var form = context.Request.Form;
            if (form.Files.Count == 1)
            {
                var result = await fileService.UploadFileAsync(Guid.NewGuid().ToString("N"), form.Files[0]);

                return result;
            }
            return "Not files uploaded";
        }).WithName("Upload workout file").RequireAuthorization();

        await app.RunAsync();
    }
}
