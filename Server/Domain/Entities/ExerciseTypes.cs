using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace Domain.Entities;

public class ExerciseTypes
{
    [Key]
    public Guid ExerciseTypeID { get; set; }
    
    public string ExerciseName { get; set; }
    
    public float CaloriesBurnedPerMinute { get; set; }
    
    public string Description { get; set; }
    
    public Category ExerciseCategory { get; set; }
}