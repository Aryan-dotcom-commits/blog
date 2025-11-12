using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AdminConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> user)
    {
        user.HasKey(a => a.userId);

        user.HasMany(fl => fl.FoodLogs)
            .WithOne(a => a.User)
            .HasForeignKey(f => f.userId)
            .OnDelete(DeleteBehavior.Cascade);

        user.HasMany(el => el.ExerciseLogs)
            .WithOne(a => a.User)
            .HasForeignKey(e => e.userId)
            .OnDelete(DeleteBehavior.Cascade);

        user.HasMany(wl => wl.WeightLogs)
            .WithOne(a => a.User)
            .HasForeignKey(w => w.userId)
            .OnDelete(DeleteBehavior.Cascade);

        user.HasMany(hl => hl.HeightLogs)
            .WithOne(a => a.User)
            .HasForeignKey(h => h.userId)
            .OnDelete(DeleteBehavior.Cascade);

        user.HasMany(c => c.Calories)
            .WithOne(a => a.User)
            .HasForeignKey(ca => ca.userId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}