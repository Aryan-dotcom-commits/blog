using System.Text;
using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class User
    {
        [Key]
        public Guid userId { get; set; }
        public string userName { get; set; }
        [Required]
        public string userMail { get; set; }
        public string userPassword { get; set; }
        public DateTime createdAt { get; set; } = DateTime.UtcNow;
        public DateTime DOB { get; set; } = DateTime.UtcNow;
        public Gender Gender { get; set; }
        public int TargetWeight { get; set; }
        public ActivityLevel ActivityLevel { get; set; }
        public DateTime updatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<WeightLogs> WeightLogs { get; set; } // 1-to-M relationship with WeightLogs
        public ICollection<HeightLogs> HeightLogs { get; set; } // 1-to-M relationship with HeightLogs
        public ICollection<FoodLogs> FoodLogs { get; set; } // 1-to-M relationship with FoodLogs
        public ICollection<ExerciseLogs> ExerciseLogs { get; set; } // 1-to-M relationship with ExerciseLogs
        public ICollection<Calories> Calories { get; set; } // 1-to-M relationship with Calories
    }
}