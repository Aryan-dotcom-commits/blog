using System.ComponentModel.DataAnnotations;
using Domain.Enums;


namespace Domain.Entities
{
    public class AdminProfile
    {
        [Key]
        public Guid profileId { get; set; }
        public Guid adminId { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public int TargetWeight { get; set; }
        public ActivityLevel ActivityLevel { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;
        public DateTime updatedAt { get; set; } = DateTime.Now;

        public Admin Admin { get; set; } // Navigation property back to Admin
    }
}
