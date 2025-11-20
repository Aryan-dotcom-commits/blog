using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enums;

namespace Domain.Entities
{
    public class FoodLogs
    {
        [Key]
        public Guid FoodId { get; set; }
        
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        
        [ForeignKey(nameof(FoodItems))]
        public Guid FoodItemId { get; set; }
        
        public int FoodQuantitiesInGrams { get; set; }
        public DateTime FoodConsumed { get; set; }
        
        public DateTime LogDate { get; set; } = DateTime.Now;
        
        public MealType MealType { get; set; }
        
        public int CaloriesConsumed { get; set; }
    }
}