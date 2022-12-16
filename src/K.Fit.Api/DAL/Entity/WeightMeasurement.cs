#pragma warning disable CS8618
namespace K.Fit.Api.DAL.Entity;

public class WeightMeasurement
{
    public long Id { get; set; }
    public Guid Gid { get; set; }
    public decimal Kilos { get; set; }
    public DateOnly MDate { get; set; }
    // EF One to many
    public long WorkoutUserId { get; set; }
    public User WorkoutUser { get; set; }

    public static void CreateWeightMeasurementEntry(string dateString, decimal kilos, User user)
    {
        user.WeightMeasurements.Add(new WeightMeasurement()
        {
            Gid = Guid.NewGuid(),
            Kilos = kilos,
            MDate = DateOnly.ParseExact(dateString, "yyyy-MM-dd"),
            WorkoutUser = user
        });
    }
}