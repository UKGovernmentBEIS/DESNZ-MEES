using System;
using System.Collections.Generic;

namespace Desnz.Mees.DataTool.Data;

public partial class AbpCrossref
{
    public short? RecordIdentifier { get; set; }

    public string? ChangeType { get; set; }

    public long? ProOrder { get; set; }

    public long? Uprn { get; set; }

    public string? XrefKey { get; set; }

    public string? CrossReference { get; set; }

    public short? Version { get; set; }

    public string? Source { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public DateOnly? LastUpdateDate { get; set; }

    public DateOnly? EntryDate { get; set; }
}
