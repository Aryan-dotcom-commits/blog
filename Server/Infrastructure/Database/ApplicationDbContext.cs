using Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext 
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    
    public DbSet<Admin> Admins { get; set; }
    public DbSet<AdminProfile> AdminProfiles { get; set; }
    public DbSet<Calories> Calories { get; set; }
    public DbSet<ExerciseLogs> ExerciseLogs { get; set; }
    public DbSet<FoodLogs> FoodLogs { get; set; }
    public DbSet<HeightLogs> HeightLogs { get; set; }
    public DbSet<WeightLogs> WeightLogs { get; set; }

}