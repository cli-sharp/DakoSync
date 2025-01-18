namespace DakoSync.Models;

public record AccountUser
{
    public required string Email { get; set; }

    public required string RealName { get; set; }
}