using System.Globalization;
using K.Fit.Api.DAL.Entity;
using K.Fit.Api.Extensions;

namespace K.Fit.Api.DAL;

public static class SeedPartOne
{
    public static void SeedBikeWorkout_AlicePartOne(FitContext context)
    {
        var user = context.Users.First(x => x.Gid == SeedConstant.AliceUserGid);

        if (user == null) throw new ArgumentException("Seed has failed. User not found");

        DateTime workDate1 = DateTime.ParseExact("2022-07-10 17:25", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();
        
        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 13.3M,
            TimeMinutes = 37,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        context.SaveChanges();
    }

    public static void SeedBikeWorkout_PartOne(FitContext context)
    {
        var user = context.Users.First(x => x.Gid == SeedConstant.DemoUserGid);

        if (user == null) throw new ArgumentException("Seed has failed. User not found");

        DateTime workDate1 = DateTime.ParseExact("2022-07-10 17:25", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 13.3M,
            TimeMinutes = 37,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-07-20 19:16", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 15.3M,
            TimeMinutes = 41,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-08-05 20:56", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 17.1M,
            TimeMinutes = 46,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-08-30 09:32", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 13.1M,
            TimeMinutes = 41,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-09-10 14:30", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 18.7M,
            TimeMinutes = 49,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-09-16 18:56", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 18.4M,
            TimeMinutes = 49,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-09-22 10:02", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 18.8M,
            TimeMinutes = 54,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-09-24 18:34", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 18.6M,
            TimeMinutes = 64,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-09-29 21:17", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 18.5M,
            TimeMinutes = 49,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-10-02 10:05", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 15.0M,
            TimeMinutes = 47,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-10-07 09:05", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 20.0M,
            TimeMinutes = 54,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-10-09 21:15", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 22.4M,
            TimeMinutes = 62,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-10-10 20:45", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 26.3M,
            TimeMinutes = 70,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-10-10 20:45", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 20M,
            TimeMinutes = 48,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-10-12 18:30", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 25.8M,
            TimeMinutes = 69,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-10-13 09:33", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 20.4M,
            TimeMinutes = 54,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-10-13 19:41", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 24M,
            TimeMinutes = 65,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-10-15 17:51", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 23M,
            TimeMinutes = 58,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-10-17 19:15", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 25.0M,
            TimeMinutes = 69,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-10-18 18:23", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 20.0M,
            TimeMinutes = 52,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-10-20 18:40", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 23.5M,
            TimeMinutes = 67,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-10-21 09:25", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 20.0M,
            TimeMinutes = 60,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-10-22 17:44", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 26.7M,
            TimeMinutes = 71,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-10-25 21:16", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 23.7M,
            TimeMinutes = 71,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-10-26 20:24", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 25.0M,
            TimeMinutes = 68,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-10-28 21:03", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 35.0M,
            TimeMinutes = 82,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-01 18:10", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 25.0M,
            TimeMinutes = 60,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-02 19:20", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 25.0M,
            TimeMinutes = 62,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-05 09:40", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 25.4M,
            TimeMinutes = 62,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-06 09:29", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 26.0M,
            TimeMinutes = 68,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-08 21:14", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 31.6M,
            TimeMinutes = 78,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-09 19:20", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 35M,
            TimeMinutes = 83,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-10 20:12", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 40.0M,
            TimeMinutes = 97,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-11 09:05", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 25.0M,
            TimeMinutes = 65,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-11 19:32", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 30.0M,
            TimeMinutes = 79,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-12 11:50", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 30.0M,
            TimeMinutes = 73,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });


        workDate1 = DateTime.ParseExact("2022-11-13 17:07", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 35.0M,
            TimeMinutes = 89,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-14 19:27", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 30.1M,
            TimeMinutes = 77,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-15 19:33", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 31.0M,
            TimeMinutes = 78,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-16 10:17", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 15.0M,
            TimeMinutes = 36,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-16 20:49", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 20.0M,
            TimeMinutes = 52,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-17 09:16", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 30.0M,
            TimeMinutes = 74,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-17 19:14", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 33.0M,
            TimeMinutes = 88,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-18 09:40", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 15.0M,
            TimeMinutes = 38,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-18 18:33", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 35.0M,
            TimeMinutes = 93,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-19 09:46", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 30.0M,
            TimeMinutes = 78,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-19 19:24", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 35.0M,
            TimeMinutes = 92,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-20 09:38", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 35.0M,
            TimeMinutes = 87,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-20 20:30", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 40.0M,
            TimeMinutes = 108,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-21 19:01", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 37.0M,
            TimeMinutes = 104,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-22 18:14", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 30.0M,
            TimeMinutes = 80,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-23 19:33", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 30.0M,
            TimeMinutes = 77,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-23 21:35", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 25.0M,
            TimeMinutes = 60,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-24 18:28", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 35.0M,
            TimeMinutes = 86,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-24 20:42", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 25.0M,
            TimeMinutes = 62,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-26 09:54", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 30.0M,
            TimeMinutes = 77,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-26 15:56", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 35.0M,
            TimeMinutes = 85,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-27 09:42", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 35.0M,
            TimeMinutes = 91,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-27 18:20", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 35.0M,
            TimeMinutes = 92,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-28 19:26", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 40.0M,
            TimeMinutes = 105,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-28 21:35", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 25.0M,
            TimeMinutes = 60,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-28 21:35", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 25.0M,
            TimeMinutes = 60,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-29 19:23", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 35.0M,
            TimeMinutes = 85,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-29 23:06", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 24.9M,
            TimeMinutes = 63,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-30 17:56", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 35M,
            TimeMinutes = 84,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-11-30 21:11", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 31M,
            TimeMinutes = 79,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-12-01 17:50", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 35.0M,
            TimeMinutes = 86,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-12-01 20:46", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 30M,
            TimeMinutes = 71,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-12-02 19:25", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 35M,
            TimeMinutes = 86,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-12-03 10:50", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 40M,
            TimeMinutes = 96,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-12-03 17:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 35M,
            TimeMinutes = 82,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-12-04 10:22", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 45M,
            TimeMinutes = 110,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-12-04 18:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 40M,
            TimeMinutes = 99,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-12-05 18:25", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
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

        workDate1 = DateTime.ParseExact("2022-12-05 21:32", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 30M,
            TimeMinutes = 71,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-12-06 18:48", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 45M,
            TimeMinutes = 113,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-12-06 21:48", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 35M,
            TimeMinutes = 84,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-12-07 19:17", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
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

        workDate1 = DateTime.ParseExact("2022-12-07 22:06", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 35M,
            TimeMinutes = 84,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-12-08 18:22", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 45M,
            TimeMinutes = 116,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-12-08 21:55", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 35M,
            TimeMinutes = 87,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        workDate1 = DateTime.ParseExact("2022-12-09 18:40", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
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

        workDate1 = DateTime.ParseExact("2022-12-10 11:58", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();

        user.Workouts.Add(new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate1,
            WorkoutDateIso = workDate1.ToString("O"),
            WorkoutDateIsoPoland = workDate1.ToPolandIso8601Format(),
            DistanceKm = 40M,
            TimeMinutes = 101,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty
        });

        context.SaveChanges();
    }

}