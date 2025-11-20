namespace Server.Application.DTO;

public class ApiResponse<T>
{
    public String Message { get; set; }
    public T Data { get; set; }
    public bool Success { get; set; }
}