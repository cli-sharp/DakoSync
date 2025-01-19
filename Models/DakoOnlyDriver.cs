namespace DakoSync.Models;

public record DakoOnlyDriver
{
    public required string CardNumber { get; set; }

    public required string CountryCode { get; set; }

    public required bool Active { get; set; }
}