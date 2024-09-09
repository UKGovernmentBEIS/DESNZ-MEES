using System;
using System.Collections.Generic;

namespace Desnz.Mees.DataTool.Data;

public partial class AbpDeliveryPoint
{
    public short? RecordIdentifier { get; set; }

    public string? ChangeType { get; set; }

    public long? ProOrder { get; set; }

    public long? Uprn { get; set; }

    public long? Udprn { get; set; }

    public string? OrganisationName { get; set; }

    public string? DepartmentName { get; set; }

    public string? SubBuildingName { get; set; }

    public string? BuildingName { get; set; }

    public short? BuildingNumber { get; set; }

    public string? DependentThoroughfare { get; set; }

    public string? Thoroughfare { get; set; }

    public string? DoubleDependentLocality { get; set; }

    public string? DependentLocality { get; set; }

    public string? PostTown { get; set; }

    public string? Postcode { get; set; }

    public string? PostcodeType { get; set; }

    public string? DeliveryPointSuffix { get; set; }

    public string? WelshDependentThoroughfare { get; set; }

    public string? WelshThoroughfare { get; set; }

    public string? WelshDoubleDependentLocality { get; set; }

    public string? WelshDependentLocality { get; set; }

    public string? WelshPostTown { get; set; }

    public string? PoBoxNumber { get; set; }

    public DateOnly? ProcessDate { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public DateOnly? LastUpdateDate { get; set; }

    public DateOnly? EntryDate { get; set; }
}
