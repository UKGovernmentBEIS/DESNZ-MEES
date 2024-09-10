using System;
using System.Collections.Generic;

namespace Desnz.Mees.DataTool.Data;

public partial class EpcNonDomestic
{
    public string? LmkKey { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Postcode { get; set; }

    public long? BuildingReferenceNumber { get; set; }

    public long? AssetRating { get; set; }

    public string? AssetRatingBand { get; set; }

    public string? PropertyType { get; set; }

    public DateOnly? InspectionDate { get; set; }

    public string? LocalAuthority { get; set; }

    public string? Constituency { get; set; }

    public string? County { get; set; }

    public DateOnly? LodgementDate { get; set; }

    public string? TransactionType { get; set; }

    public long? NewBuildBenchmark { get; set; }

    public long? ExistingStockBenchmark { get; set; }

    public long? BuildingLevel { get; set; }

    public string? MainHeatingFuel { get; set; }

    public string? OtherFuelDesc { get; set; }

    public string? SpecialEnergyUses { get; set; }

    public string? RenewableSources { get; set; }

    public long? FloorArea { get; set; }

    public double? StandardEmissions { get; set; }

    public double? TargetEmissions { get; set; }

    public double? TypicalEmissions { get; set; }

    public double? BuildingEmissions { get; set; }

    public string? AirconPresent { get; set; }

    public double? AirconKwRating { get; set; }

    public double? EstimatedAirconKwRating { get; set; }

    public long? AcInspectionCommissioned { get; set; }

    public string? BuildingEnvironment { get; set; }

    public string? Address { get; set; }

    public string? LocalAuthorityLabel { get; set; }

    public string? ConstituencyLabel { get; set; }

    public string? Posttown { get; set; }

    public DateTime? LodgementDatetime { get; set; }

    public long? PrimaryEnergyValue { get; set; }

    public long? Uprn { get; set; }

    public string? UprnSource { get; set; }
}
