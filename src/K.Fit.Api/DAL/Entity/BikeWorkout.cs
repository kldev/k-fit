using System.Globalization;
using K.Fit.Api.Extensions;

#pragma warning disable CS8618
namespace K.Fit.Api.DAL.Entity;

public class BikeWorkout
{
    public long Id { get; set; }
    public Guid Gid { get; set; }
    public DateTime WorkoutDate { get; set; } = DateTime.UtcNow;
    public string WorkoutDateIso { get; set; } = string.Empty;
    public string WorkoutDateIsoPoland { get; set; } = string.Empty;
    public decimal DistanceKm { get; set; } = 20;
    public long TimeMinutes { get; set; } = 60;
    public DateTime CreateAt { get; set; } = DateTime.UtcNow;
    public string Notes { get; set; } = string.Empty;
    public string PictureBucketId { get; set; } = string.Empty;
    public string PictureBucketName { get; set; } = string.Empty;

    public Guid UserGid { get; set; }
    public long WorkoutUserId { get; set; }
    // EF One to many
    public User WorkoutUser { get; set; }


    public static void CreateWorkoutEntry(string dateString, decimal distance, int time, User user)
    {
        var workDate = DateTime.ParseExact(dateString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
            .ToUniversalTime();
        var bw = new BikeWorkout()
        {
            Gid = Guid.NewGuid(),
            Notes = "",
            WorkoutDate = workDate,
            WorkoutDateIso = workDate.ToString("O"),
            WorkoutDateIsoPoland = workDate.ToPolandIso8601Format(),
            DistanceKm = distance,
            TimeMinutes = time,
            WorkoutUser = user,
            PictureBucketId = string.Empty,
            PictureBucketName = string.Empty,
            UserGid = user.Gid
        };

        user.Workouts.Add(bw);
    }

}