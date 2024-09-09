using System;
using System.Collections.Generic;

namespace Desnz.Mees.DataTool.Data;

public partial class AbpStreetDescriptor
{
    public short? RecordIdentifier { get; set; }

    public string? ChangeType { get; set; }

    public long? ProOrder { get; set; }

    public int? Usrn { get; set; }

    public string? StreetDescription { get; set; }

    public string? Locality { get; set; }

    public string? TownName { get; set; }

    public string? AdministrativeArea { get; set; }

    public string? Language { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public DateOnly? LastUpdateDate { get; set; }

    public DateOnly? EntryDate { get; set; }
}
