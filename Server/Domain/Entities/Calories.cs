using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Calories
    {
        [Key]
        public Guid CalorieId { get; set; }
        public int TotalCaloriesConsumed { get; set; }
        public int TotalCaloriesBurned { get; set; }
        public int NetCalories { get; set; }
        public DateTime logDate { get; set; } = DateTime.Now;
        public DateTime LastCalorieUpdate { get; set; } = DateTime.Now;

        public Guid userId { get; set; }
        public User User { get; set; }
    }
}