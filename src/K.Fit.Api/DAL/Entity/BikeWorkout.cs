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

    public long WorkoutUserId { get; set; }
    // EF One to many
    public User WorkoutUser { get; set; }

}