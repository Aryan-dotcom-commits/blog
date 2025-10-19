using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace Domain.Entities
{
    public class FoodLogs
    {
        [Key]
        public Guid FoodId { get; set; }
        public string FoodName { get; set; }
        public FoodCategory FoodCategory { get; set; }
        public int FoodQuantities { get; set; }
        public int CaloriesPerUnit { get; set; }
        public int TotalCalories { get; set; }
        public int? Protein { get; set; }
        public int? Carbs { get; set; }
        public int? Fats { get; set; }
        public DateTime LogDate { get; set; } = DateTime.Now;

        public Guid adminId { get; set; }
        public Admin Admin { get; set; } // Foreign key to Admin
    }
}