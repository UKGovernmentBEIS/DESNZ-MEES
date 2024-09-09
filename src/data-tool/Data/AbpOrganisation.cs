using System;
using System.Collections.Generic;

namespace Desnz.Mees.DataTool.Data;

public partial class AbpOrganisation
{
    public short? RecordIdentifier { get; set; }

    public string? ChangeType { get; set; }

    public long? ProOrder { get; set; }

    public long? Uprn { get; set; }

    public string? OrgKey { get; set; }

    public string? Organisation { get; set; }

    public string? LegalName { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public DateOnly? LastUpdateDate { get; set; }

    public DateOnly? EntryDate { get; set; }
}
