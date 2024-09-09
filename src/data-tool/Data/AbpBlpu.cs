using System;
using System.Collections.Generic;

namespace Desnz.Mees.DataTool.Data;

public partial class AbpBlpu
{
    public short? RecordIdentifier { get; set; }

    public string? ChangeType { get; set; }

    public long? ProOrder { get; set; }

    public long? Uprn { get; set; }

    public short? LogicalStatus { get; set; }

    public short? BlpuState { get; set; }

    public DateOnly? BlpuStateDate { get; set; }

    public long? ParentUprn { get; set; }

    public double? XCoordinate { get; set; }

    public double? YCoordinate { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public short? Rpc { get; set; }

    public short? LocalCustodianCode { get; set; }

    public string? Country { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public DateOnly? LastUpdateDate { get; set; }

    public DateOnly? EntryDate { get; set; }

    public string? AddressbasePostal { get; set; }

    public string? PostcodeLocator { get; set; }

    public short? MultiOccCount { get; set; }
}
