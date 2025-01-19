namespace DakoSync.Models;

public record FeatureBooking
{
    // ObjectUID
    public required string WfsObjectUid { get; set; }

    // Feature
    public FeatureType? FeatureType { get; set; }

    // ?
    public DateTime? FeatureActivationDate { get; set; }

    // ?
    public DateTime? FeatureTerminationDate { get; set; }
}

public enum FeatureType
{
    BASIC,
    PLUS
}