namespace DakoSync.Models;

public record DakoOnlyVehicle
{
    public required string Vin { get; set; }

    public required bool Active { get; set; }
}
