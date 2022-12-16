using K.Fit.Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace K.Fit.Api.DAL.EntityConfig;

public class WeightMeasurementConfig : IEntityTypeConfiguration<WeightMeasurement>
{
    public void Configure(EntityTypeBuilder<WeightMeasurement> builder)
    {
        builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
        builder.Property(x => x.Gid).HasColumnName("gid");
        builder.Property(x => x.Kilos).HasColumnName("kilos").HasPrecision(8, 2);
        builder.Property(x => x.MDate).HasColumnName("m_date");
        builder.Property(x => x.WorkoutUserId).HasColumnName("user_id");

        builder.HasOne(x => x.WorkoutUser)
            .WithMany(x => x.WeightMeasurements)
            .HasForeignKey(x => x.WorkoutUserId).OnDelete(DeleteBehavior.NoAction);

        builder.ToTable("weight");
    }
}
