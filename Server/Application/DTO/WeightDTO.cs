using Domain.Enums;

public class WeightDTO
{
    public decimal CurrentWeight { get; set; }
    public WeightUnits WeightUnit { get; set; }
    public string Notes { get; set; }
    public bool IsGoalAchieved { get; set; }
    public DateTime loggedAt { get; set; } = DateTime.UtcNow;
}
