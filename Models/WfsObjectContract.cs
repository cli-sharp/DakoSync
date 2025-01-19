namespace DakoSync.Models;

public record WfsObjectContract
{
    // ObjectUID
    public required string WfsObjectUid { get; set; }

    // ContractNumber
    public required string ContractNo { get; set; }

    // ?
    public string? ContractBeginDate { get; set; }

    // ?
    public string? ContractEndDate { get; set; }

    // Tariff
    public string? ContractTariffName { get; set; }

    // ObuSerialNumber
    public string? ContractObuSerialNo { get; set; }

    // ObuFirmwareVersion
    public string? ContractObuFwVersion { get; set; }

    // ObuType
    public string? ContractObuType { get; set; }

    // PndMapVersion
    public string? PndMapVersion { get; set; }

    // PndNcVersion
    public string? PndNcVersion { get; set; }

    // PndSerialNumber
    public string? PndSerialNo { get; set; }

    // PndType
    public string? PndType { get; set; }

    // SimIccId
    public string? SimIccId { get; set; }
}