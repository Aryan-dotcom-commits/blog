using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace Domain.Entities
{
    public class WeightLogs
    {
        [Key]
        public Guid weightLogId { get; set; }
        public decimal CurrentWeight { get; set; }
        public WeightUnits WeightUnit { get; set; } 

        public string Notes { get; set; }
        
        public bool IsGoalAchieved { get; set; }
        public DateTime loggedAt { get; set; } = DateTime.UtcNow;
        public Guid userId { get; set; } // Foreign key to Admin
        public User User { get; set; }
    }
}