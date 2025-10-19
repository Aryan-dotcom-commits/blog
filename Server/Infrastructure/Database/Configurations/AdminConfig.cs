using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AdminConfig : IEntityTypeConfiguration<Admin>
{
    public void Configure(EntityTypeBuilder<Admin> admin)
    {
        admin.HasKey(a => a.adminId);

        admin.HasOne(a => a.AdminProfile)
            .WithOne(p => p.Admin)
            .HasForeignKey<AdminProfile>(p => p.adminId)
            .OnDelete(DeleteBehavior.Cascade);

        admin.HasMany(fl => fl.FoodLogs)
            .WithOne(a => a.Admin)
            .HasForeignKey(f => f.adminId)
            .OnDelete(DeleteBehavior.Cascade);

        admin.HasMany(el => el.ExerciseLogs)
            .WithOne(a => a.Admin)
            .HasForeignKey(e => e.adminId)
            .OnDelete(DeleteBehavior.Cascade);

        admin.HasMany(wl => wl.WeightLogs)
            .WithOne(a => a.Admin)
            .HasForeignKey(w => w.adminId)
            .OnDelete(DeleteBehavior.Cascade);

        admin.HasMany(hl => hl.HeightLogs)
            .WithOne(a => a.Admin)
            .HasForeignKey(h => h.adminId)
            .OnDelete(DeleteBehavior.Cascade);

        admin.HasMany(c => c.Calories)
            .WithOne(a => a.Admin)
            .HasForeignKey(ca => ca.adminId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}