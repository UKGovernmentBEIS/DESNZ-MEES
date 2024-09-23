using Microsoft.EntityFrameworkCore;

namespace Desnz.Mees.DataTool.Data.Repositories;

public interface IEpcSummaryRepository
{
    Task<List<EpcSummary>> GetEpcSummaries(string localAuthority, int limit);
}

public class EpcSummaryRepository(IDataToolContext dataToolContext) : IEpcSummaryRepository
{
    public async Task<List<EpcSummary>> GetEpcSummaries(string localAuthority, int limit = 100)
    {
        var result = await dataToolContext.Database
            .SqlQueryRaw<EpcSummary>(Sql)
            .Where(summary => summary.LocalAuthority == localAuthority)
            .Take(limit)
            .OrderBy(summary => summary.Postcode)
            .ToListAsync();
        return result;
    }

    private const string Sql = @"
with single_poly as (
    -- there's still a lot of title numbers sharing uprn
    -- in the fake poly data due to shortcuts in data matching
    -- so this cte removes the dupes, 1 title numb to uprn
    -- TODO remove this IRL
    select *
    from (
             select title_number,
                    uprn,
                    row_number() over (partition by uprn order by score desc) as row_num
             from public.""hmlr-poly-title-to-uprn""
         ) as hmlr_part
    where row_num = 1
)

select
    epc.""lmk-key"", epc.address, epc.posttown, epc.postcode, epc.""asset-rating"", epc.""asset-rating-band"", epc.""floor-area"", epc.""local-authority"",
    hmlr_ccod.""Tenure"", hmlr_ccod.""Proprietor Name (1)"", hmlr_ccod.""Proprietor (1) Address (1)"", hmlr_ccod.""Title Number"", hmlr_ccod.""Date Proprietor Added"",
    ch.""CompanyName"",
    voa.rateable_value

from public.""epc-non-domestic"" epc
left join public.os_recordtype_28 os28
    on cast(os28.""UPRN"" as bigint) = epc.uprn
left join public.os_recordtype_23 os23
    on os23.""UPRN"" = os28.""UPRN""
left join single_poly hmlr_poly
    on cast(hmlr_poly.""uprn"" as bigint) = epc.uprn
left join public.""hmlr-ccod"" hmlr_ccod
     on hmlr_ccod.""Title Number"" = hmlr_poly.""title_number""
left join public.""ch-company"" ch
    on ch."" CompanyNumber"" = hmlr_ccod.""Company Registration No. (1)""
left join public.""voa-business-rates"" voa
    on voa.uarn = os23.""CROSS_REFERENCE""
where epc.""asset-rating-band"" in ('F', 'G')
    and hmlr_ccod.""Tenure"" != 'Freehold'";
}