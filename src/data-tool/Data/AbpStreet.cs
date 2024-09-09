using System;
using System.Collections.Generic;

namespace Desnz.Mees.DataTool.Data;

public partial class AbpStreet
{
    public short? RecordIdentifier { get; set; }

    public string? ChangeType { get; set; }

    public long? ProOrder { get; set; }

    public int? Usrn { get; set; }

    public short? RecordType { get; set; }

    public short? SwaOrgRefNaming { get; set; }

    public short? State { get; set; }

    public DateOnly? StateDate { get; set; }

    public short? StreetSurface { get; set; }

    public short? StreetClassification { get; set; }

    public short? Version { get; set; }

    public DateOnly? StreetStartDate { get; set; }

    public DateOnly? StreetEndDate { get; set; }

    public DateOnly? LastUpdateDate { get; set; }

    public DateOnly? RecordEntryDate { get; set; }

    public double? StreetStartX { get; set; }

    public double? StreetStartY { get; set; }

    public double? StreetEndX { get; set; }

    public double? StreetEndY { get; set; }

    public short? StreetTolerance { get; set; }
}
