using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enums;

namespace Domain.Entities
{
    public class WeightLogs
    {
        [Key]
        public Guid WeightLogID { get; set; }
        [ForeignKey(nameof(User))]
        public Guid UserID { get; set; }
        
        public int currentWeight { get; set; }
        public DateTime LoggedDate { get; set; } = DateTime.Now;
        
        public string Notes { get; set; }
    }
}