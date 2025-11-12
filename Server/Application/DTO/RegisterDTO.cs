using Domain.Enums;

public class RegisterDTO
{
    public string userName { get; set; }
    public string userEmail { get; set; }
    public string userPassword { get; set; }
    public DateTime DOB { get; set; } = DateTime.UtcNow;
    public Gender Gender { get; set; }
    public int TargetWeight { get; set; }
    public ActivityLevel ActivityLevel { get; set; }

}
