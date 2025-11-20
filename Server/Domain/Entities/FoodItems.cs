using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace Domain.Entities;

public class FoodItems
{
    [Key]
    public Guid FoodItemId { get; set; }
    
    public string FoodName { get; set; }
    
    public int Caloriesper100gram { get; set; }
    
    public FoodType FoodType { get; set; }
}