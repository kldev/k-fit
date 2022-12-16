using K.Fit.Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace K.Fit.Api.DAL.EntityConfig;

public class BikeWorkoutConfig : IEntityTypeConfiguration<BikeWorkout>
{
    public void Configure(EntityTypeBuilder<BikeWorkout> builder)
    {
        builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
        builder.Property(x => x.Notes).HasMaxLength(2048).HasColumnName("notes");
        builder.Property(x => x.PictureBucketId).HasMaxLength(512).HasColumnName("bucket_item_id");
        builder.Property(x => x.PictureBucketName).HasMaxLength(512).HasColumnName("bucket_name");
        builder.Property(x => x.WorkoutDate).HasColumnName("w_date");
        builder.Property(x => x.TimeMinutes).HasColumnName("time_minutes");
        builder.Property(x => x.WorkoutDateIsoPoland).HasMaxLength(100).HasColumnName("w_date_iso_poland");
        builder.Property(x => x.WorkoutDateIso).HasMaxLength(100).HasColumnName("w_date_iso");
        builder.Property(x => x.WorkoutUserId).HasColumnName("user_id");
        builder.Property(x => x.UserGid).HasColumnName("user_gid");

        builder.HasIndex(x => x.WorkoutDate);
        builder.Property(x => x.Gid).IsRequired().HasColumnName("gid");
        builder.Property(x => x.CreateAt).HasDefaultValueSql("CURRENT_TIMESTAMP").HasColumnName("create_at");
        builder.Property(x => x.DistanceKm).HasPrecision(4, 2).HasColumnName("distance_km");

        builder.HasOne(x => x.WorkoutUser)
            .WithMany(x => x.Workouts)
            .HasForeignKey(x => x.WorkoutUserId).OnDelete(DeleteBehavior.NoAction);

        builder.HasIndex(x => x.UserGid);

        builder.ToTable("bike_w");
    }
}