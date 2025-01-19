namespace DakoSync.Models;

public record WfsDriver
{
    public required string Uid { get; set; }

    public bool? Active { get; set; }

    public string? Name { get; set; }

    public string? DriverCardNumber { get; set; }

    public string? DriverCardCountryCode { get; set; }

    public DateTime? DriverCardValidUntil { get; set; }

    public string? DriverLicenseNumber { get; set; }

    public string? LocationStreet { get; set; }

    public string? LocationCity { get; set; }

    public string? LocationPostcode { get; set; }

    public string? LocationCountry { get; set; }

    public string? PhoneBusiness { get; set; }

    public string? PhoneMobile { get; set; }

    public string? PhonePersonal { get; set; }
}