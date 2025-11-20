using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Server.Infrastructure.Database;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base (options){ }
    
    public DbSet<Roles> Role { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<WeightLogs> WeightLog { get; set; }
    public DbSet<FoodLogs> FoodLog { get; set; }
    public DbSet<FoodItems> FoodItem { get; set; }
    public DbSet<ExerciseTypes> ExerciseType { get; set; }
    public DbSet<ExerciseLogs> ExerciseLog { get; set; }
    public DbSet<CaloriesSummary> CaloriesSummaries { get; set; }
}