namespace DakoSync.Models;

public record WfsObject
{
    // ObjectUID
    public required string Uid { get; set; }

    // ?
    public string? ObjectName { get; set; }

    // ?
    public string? ObjectNumber { get; set; }

    // Registration
    public string? LicensePlate { get; set; }

    // VIN
    public string? Vin { get; set; }

    // Description
    public string? Description { get; set; }

    // ! Only in MasterDB
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