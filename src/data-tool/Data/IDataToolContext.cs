using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Desnz.Mees.DataTool.Data;

public interface IDataToolContext
{
    DbSet<ChCompany> ChCompanies { get; set; }
    DbSet<EpcNonDomestic> EpcNonDomestics { get; set; }
    DbSet<EpcToUprn> EpcToUprns { get; set; }
    DbSet<HmlrCcod> HmlrCcods { get; set; }
    DbSet<HmlrOcod> HmlrOcods { get; set; }
    DbSet<HmlrPolyTitleToUprn> HmlrPolyTitleToUprns { get; set; }
    DbSet<OsRecordtype21> OsRecordtype21s { get; set; }
    DbSet<OsRecordtype23> OsRecordtype23s { get; set; }
    DbSet<OsRecordtype24> OsRecordtype24s { get; set; }
    DbSet<OsRecordtype28> OsRecordtype28s { get; set; }
    DbSet<OsRecordtype31> OsRecordtype31s { get; set; }
    DbSet<OsRecordtype32> OsRecordtype32s { get; set; }
    DbSet<VoaBusinessRate> VoaBusinessRates { get; set; }
    DatabaseFacade Database { get; }
}