namespace DakoSync.Models;

public record Account
{
    public required string Uid { get; set; }

    public string? AccountName { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerState { get; set; }

    public string? CustomerZip { get; set; }

    public string? CustomerCity { get; set; }

    public string? CustomerStreet { get; set; }

    public string? CustomerEmail { get; set; }

    public string[]? CompanyCardIccIds { get; internal set; }

    public bool Active { get; internal set; }

    public bool Blocked { get; internal set; }
}