namespace DakoSync.Models;

public record AccountUser
{
    public required string RealName { get; set; }

    public string? Email { get; set; }
}