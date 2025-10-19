using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace Domain.Entities
{
    public class HeightLogs
    {
        [Key]
        public Guid heightLogId { get; set; }
        public int CurrentHeight { get; set; }
        public HeightUnits HeightUnit { get; set; }
        public Guid adminId { get; set; } // Navigation property back to Admin
        public Admin Admin { get; set; }
    }
}