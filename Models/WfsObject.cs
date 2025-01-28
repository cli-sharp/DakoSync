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

    public bool Active { get; internal set; }

    public bool RemoteDownload { get; internal set; }
}