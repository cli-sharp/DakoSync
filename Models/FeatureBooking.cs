namespace DakoSync.Models;

public record FeatureBooking
{
    public required string ObjectUid { get; set; }

    public FeatureType? FeatureType { get; set; }

    public DateTime? FeatureActivationDate { get; set; }

    public DateTime? FeatureTerminationDate { get; set; }
}

public enum FeatureType
{
    BASIC,
    PLUS
}