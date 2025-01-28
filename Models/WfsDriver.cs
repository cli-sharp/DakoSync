namespace DakoSync.Models;

public record WfsDriver
{
    // DriverUID
    public required string Uid { get; set; }

    // FirstNames
    public string? FirstNames { get; set; }

    // Surename
    public string? SurName { get; set; }

    // CardNumber
    public string? DriverCardNumber { get; set; }

    // Nation
    public string? DriverCardCountryCode { get; set; }

    // CardExpirationDate
    public DateTime? DriverCardValidUntil { get; set; }

    // LicenceNumber
    public string? DriverLicenseNumber { get; set; }

    // Street
    public string? LocationStreet { get; set; }

    // ?
    public string? LocationCity { get; set; }

    // ZipCode
    public string? LocationPostcode { get; set; }

    // ?
    public string? LocationCountry { get; set; }

    // Phone
    public string? Phone { get; set; }

    public bool Active { get; internal set; }
}