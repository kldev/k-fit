using System.Globalization;
using K.Fit.Api.DAL.Entity;
using K.Fit.Api.Security;
using Microsoft.EntityFrameworkCore;
using K.Fit.Api.Extensions;
using K.Fit.Api.DAL.Seed;

namespace K.Fit.Api.DAL;

public static class SeedService
{

    public static void Initialize(IServiceProvider serviceProvider)
    {
        IPasswordHasher hasher = serviceProvider.GetRequiredService<IPasswordHasher>();

        // save changes / end transaction
        using (var context = new FitContext(serviceProvider.GetRequiredService<DbContextOptions<FitContext>>()))
        {
            SeedUsers(context, hasher);
        }

        // save changes / end transaction
        using (var context = new FitContext(serviceProvider.GetRequiredService<DbContextOptions<FitContext>>()))
        {
            SeedWeightMeasurement.Seed(context);
        }

        // save changes / end transaction
        using (var context = new FitContext(serviceProvider.GetRequiredService<DbContextOptions<FitContext>>()))
        {
            SeedServiceArchive.Seed(context);
            SeedActivePeriodWorkout.Seed(context);
        }
    }



    private static void SeedUsers(FitContext context, IPasswordHasher hasher)
    {
        var user = new User()
        {
            Active = true,
            Gid = SeedConstant.DemoUserGid,
            Password = hasher.Hash("demo123"),
            Username = "demo",
        };

        context.Set<User>().Add(user);
        context.SaveChanges();
    }
}