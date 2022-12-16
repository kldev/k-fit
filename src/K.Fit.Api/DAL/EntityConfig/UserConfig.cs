using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace K.Fit.Api.DAL.EntityConfig;

public class UserConfig : IEntityTypeConfiguration<Entity.User>
{
    public void Configure(EntityTypeBuilder<Entity.User> builder)
    {
        builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
        builder.Property(x => x.Username).HasMaxLength(50).IsRequired().HasColumnName("username");
        builder.Property(x => x.Password).HasMaxLength(255).IsRequired().HasColumnName("password");
        builder.Property(x => x.Gid).IsRequired().HasColumnName("gid");
        builder.Property(x => x.CreateAt).HasDefaultValueSql("CURRENT_TIMESTAMP").HasColumnName("create_at");
        builder.Property(x => x.Active).HasColumnName("active");
        builder.HasIndex(x => x.Username).IsUnique();

        builder.ToTable("users");
    }
}