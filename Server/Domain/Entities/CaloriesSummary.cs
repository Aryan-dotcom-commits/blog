using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Domain.Entities;

public class CaloriesSummary
{
    [Key]
    public Guid CaloriesSummaryId { get; set; }
    
    [ForeignKey((nameof(User)))]
    public Guid UserId { get; set; } 
    
    public DateTime SummaryDate { get; set; }
    
    public int TotalCaloriesConsumed { get; set; }
    public int TotalCaloriesBurned { get; set; }
    
    public int NetCalories { get; set; }
    public DateTime CreatedAt { get; set; }
}