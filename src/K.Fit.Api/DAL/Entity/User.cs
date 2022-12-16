namespace K.Fit.Api.DAL.Entity;

public class User
{
    public long Id { get; set; }
    public Guid Gid { get; set; } = Guid.NewGuid();
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public bool Active { get; set; } = false;
    public DateTime CreateAt { get; set; } = DateTime.UtcNow;

    public List<BikeWorkout> Workouts { get; set; } = new List<BikeWorkout>();
    public List<WeightMeasurement> WeightMeasurements { get; set; } = new List<WeightMeasurement>();
}
