using System.ComponentModel.DataAnnotations.Schema;

namespace Desnz.Mees.DataTool.Data;

public class EpcSummary
{
    [Column("lmk-key")]
    public string? LmkKey { get; set; }
    [Column("address")]
    public string? Address { get; set; }
    [Column("posttown")]
    public string? Posttown { get; set; }
    [Column("postcode")]
    public string? Postcode { get; set; }
    [Column("asset-rating")]
    public long? AssetRating { get; set; }
    [Column("asset-rating-band")]
    public string? AssetRatingBand { get; set; }
    [Column("floor-area")]
    public long? FloorArea { get; set; }
    [Column("local-authority")]
    public string? LocalAuthority { get; set; }
    
    [Column("Title Number")]
    public string? TitleNumber { get; set; }
    [Column("Tenure")]
    public string? Tenure { get; set; }
    [Column("Proprietor Name (1)")]
    public string? ProprietorName1 { get; set; }
    [Column("Proprietor (1) Address (1)")]
    public string? Proprietor1Address1 { get; set; }
    [Column("Date Proprietor Added")]
    public string? DateProprietorAdded { get; set; }
    
    [Column("CompanyName")]
    public string? CompanyName { get; set; }
    
    [Column("rateable_value")]
    public long? RateableValue { get; set; }
}