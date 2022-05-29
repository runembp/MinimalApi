namespace MinimalApi.Models;

public class Customer
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = string.Empty;
}