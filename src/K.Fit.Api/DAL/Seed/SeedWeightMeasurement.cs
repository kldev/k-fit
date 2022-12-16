using K.Fit.Api.DAL.Entity;
namespace K.Fit.Api.DAL.Seed;

public static class SeedWeightMeasurement
{
    public static void Seed(FitContext context)
    {
        var user = context.Users.First(x => x.Gid == SeedConstant.DemoUserGid);

        if (user == null) throw new ArgumentException("Seed has failed. User not found");

        WeightMeasurement.CreateWeightMeasurementEntry("2022-09-01", 113, user);
        WeightMeasurement.CreateWeightMeasurementEntry("2022-10-01", 112, user);
        WeightMeasurement.CreateWeightMeasurementEntry("2022-11-05", 107, user);
        WeightMeasurement.CreateWeightMeasurementEntry("2022-11-18", 103.9M, user);
        WeightMeasurement.CreateWeightMeasurementEntry("2022-12-04", 101.3M, user);
        WeightMeasurement.CreateWeightMeasurementEntry("2022-12-17", 102.2M, user);
        WeightMeasurement.CreateWeightMeasurementEntry("2022-12-23", 100.2M, user);
        WeightMeasurement.CreateWeightMeasurementEntry("2022-12-31", 99M, user);
        WeightMeasurement.CreateWeightMeasurementEntry("2023-01-10", 97M, user);
        WeightMeasurement.CreateWeightMeasurementEntry("2023-01-17", 96.1M, user);
        WeightMeasurement.CreateWeightMeasurementEntry("2023-03-19", 94.7M, user);
        WeightMeasurement.CreateWeightMeasurementEntry("2023-05-01", 95.5M, user);
        context.SaveChanges();
    }

}