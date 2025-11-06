using Domain.Enums;

public class RegisterDTO
{
    public string adminName { get; set; }
    public string adminEmail { get; set; }
    public string adminPassword { get; set; }
    public DateTime DOB { get; set; } = DateTime.UtcNow;
    public Gender Gender { get; set; }
    public int TargetWeight { get; set; }
    public ActivityLevel ActivityLevel { get; set; }

}

public class RegisterResponse
{
    public string Success { get; set; }
    public string Message { get; set; }
    public RegisterDTO Data { get; set; }
}