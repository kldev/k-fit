using System.Globalization;
using K.Fit.Api.DAL.Entity;
using K.Fit.Api.Security;
using Microsoft.EntityFrameworkCore;
using K.Fit.Api.Extensions;


namespace K.Fit.Api.DAL;

public partial class SeedService
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
            SeedPartOne.SeedBikeWorkout_AlicePartOne(context);
            SeedPartOne.SeedBikeWorkout_PartOne(context);
            SeedBikeWorkout(context);
        }
    }

    #region SeedBikeWorkout

    private static void SeedBikeWorkout(FitContext context)
    {
        var user = context.Users.First(x => x.Gid == SeedConstant.DemoUserGid);
        if (user == null) throw new ArgumentException("Seed has failed. User not found");

        var workDate1 = DateTime.ParseExact("2022-12-10 21:29", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 45M,
            TimeMinutes = 108,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-12-11 10:12", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 45M,
            TimeMinutes = 114,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-12-11 19:25", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 40M,
            TimeMinutes = 103,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-12-12 18:16", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 45M,
            TimeMinutes = 106,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-12-13 19:31", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 45M,
            TimeMinutes = 124,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-12-14 19:04", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 50M,
            TimeMinutes = 146,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });


        workDate1 = DateTime.ParseExact("2022-12-15 20:08", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 50M,
            TimeMinutes = 128,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        context.SaveChanges();
    }
    #endregion

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
        
        var alice = new User()
        {
            Active = true,
            Gid = SeedConstant.AliceUserGid,
            Password = hasher.Hash("alice123"),
            Username = "alice",
        };

        context.Set<User>().Add(alice);
        
        context.SaveChanges();
    }
}