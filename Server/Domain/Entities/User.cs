using System.Text;
using Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;

namespace Domain.Entities
{
    public class User
    {
        [Key]
        public Guid userID { get; set; }
        public string username { get; set; }
        public string userPassword { get; set; }
        public string useremail { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public int TargetWeight { get; set; }
        public ActivityLevel ActivityLevel { get; set; }
        
        [ForeignKey(nameof(Roles))]
        public Guid RolesID { get; set; }
        
        public DateTime CreatedAt { get; set; }
    }
}