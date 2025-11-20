using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enums;

namespace Domain.Entities
{
    public class ExerciseLogs
    {
        [Key]
        public Guid exerciseLogId { get; set; }
        
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        
        [ForeignKey(nameof(ExerciseTypes))]
        public Guid ExerciseTypeId { get; set; }
        
        public int DurationInMinues { get; set; }
        public int CaloriesBurned { get; set; }
        public Intensity Intensity { get; set; }
        public DateTime exerciseDate { get; set; } = DateTime.Now;
        
        public string Notes { get; set; }

    }
}