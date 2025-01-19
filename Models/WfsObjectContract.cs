namespace DakoSync.Models;

public record WfsObjectContract
{
    public required string WfsObjectUid { get; set; }

    public required string ContractNo { get; set; }

    public string? ContractBeginDate { get; set; }

    public string? ContractEndDate { get; set; }

    public string? ContractTariffName { get; set; }

    public string? ContractObuSerialNo { get; set; }

    public string? ContractObuOsVersion { get; set; }

    public string? ContractObuAppVersion { get; set; }

    public string? ContractObuType { get; set; }

    public string? PndMapVersion { get; set; }

    public string? PndNcVersion { get; set; }

    public string? PndSerialNo { get; set; }

    public string? PndType { get; set; }

    public string? SimIccId { get; set; }
}