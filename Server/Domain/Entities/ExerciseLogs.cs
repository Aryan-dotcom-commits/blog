using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace Domain.Entities
{
    public class ExerciseLogs
    {
        [Key]
        public Guid exerciseLogId { get; set; }
        public string exerciseName { get; set; }
        public BodyPart bodyPart { get; set; }
        public int TotalSets { get; set; }
        public int RepsPerSet { get; set; }
        public int TotalReps { get; set; }
        public int DurationInMinues { get; set; }
        public int CaloriesBurned { get; set; }
        public DateTime exerciseDate { get; set; } = DateTime.Now;

        public Guid adminId { get; set; }
        public Admin Admin { get; set; }
    }
}