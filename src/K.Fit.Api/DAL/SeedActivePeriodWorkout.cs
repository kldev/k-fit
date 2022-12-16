using System.Globalization;
using K.Fit.Api.DAL.Entity;
using K.Fit.Api.Extensions;

namespace K.Fit.Api.DAL;

public static class SeedActivePeriodWorkout
{
    public static void Seed(FitContext context)
    {
        var user = context.Users.First(x => x.Gid == SeedConstant.DemoUserGid);
        if (user == null) throw new ArgumentException("Seed has failed. User not found");

        BikeWorkout.CreateWorkoutEntry("2023-05-01 10:35", 25M, 70, user);

        context.SaveChanges();
    }
}