using System.Reflection;
using K.Fit.Api.DAL.Entity;
using K.Fit.Api.Security;
using Microsoft.EntityFrameworkCore;

namespace K.Fit.Api.DAL;

public class FitContext : DbContext
{
    public FitContext(DbContextOptions<FitContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<BikeWorkout> BikeWorkouts { get; set; }
    public DbSet<WeightMeasurement> WeightMeasurements { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("fit");

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}