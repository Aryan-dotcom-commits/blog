using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Admin
    {
        [Key]
        public Guid adminId { get; set; }
        public string adminName { get; set; }
        public string adminEmail { get; set; }
        public string adminPassword { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;

        public AdminProfile AdminProfile { get; set; } // 1-to-1 relationship with AdminProfile
        public ICollection<WeightLogs> WeightLogs { get; set; } // 1-to-M relationship with WeightLogs
        public ICollection<HeightLogs> HeightLogs { get; set; } // 1-to-M relationship with HeightLogs
        public ICollection<FoodLogs> FoodLogs { get; set; } // 1-to-M relationship with FoodLogs
        public ICollection<ExerciseLogs> ExerciseLogs { get; set; } // 1-to-M relationship with ExerciseLogs
        public ICollection<Calories> Calories { get; set; } // 1-to-M relationship with Calories
    }
}