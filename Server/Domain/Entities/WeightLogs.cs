using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace Domain.Entities
{
    public class WeightLogs
    {
        [Key]
        public Guid weightLogId { get; set; }
        public int CurrentWeight { get; set; }
        public WeightUnits WeightUnit { get; set; }
        public bool IsGoalAchieved { get; set; }
        public DateTime loggedAt { get; set; } = DateTime.Now;
        public Guid adminId { get; set; } // Foreign key to Admin
        public Admin Admin { get; set; }
    }
}