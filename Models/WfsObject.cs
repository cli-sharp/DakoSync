namespace DakoSync.Models;

public record WfsObject
{
    public required string Uid { get; set; }

    public bool? Active { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectNumber { get; set; }

    public string? LicensePlate { get; set; }

    public string? Vin { get; set; }

    public string? Description { get; set; }

    public TachographType? TachographType { get; set; }
}

public enum TachographType
{
    STR,
    DTCO,
    STAC,
    EFAS,
    Unknown,
}