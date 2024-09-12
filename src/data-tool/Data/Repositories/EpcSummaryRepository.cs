using Microsoft.EntityFrameworkCore;

namespace Desnz.Mees.DataTool.Data.Repositories;

public interface IEpcSummaryRepository
{
    Task<List<EpcNonDomestic>> GetEpcSummaries(string? localAuthority);
}

public class EpcSummaryRepository(IDataToolContext dataToolContext) : IEpcSummaryRepository
{
    public async Task<List<EpcNonDomestic>> GetEpcSummaries(string? localAuthority)
    {
        var result = await dataToolContext.EpcNonDomestics
            .Where(domestic => domestic.LocalAuthority == localAuthority)
            .ToListAsync();
        return result;
    }
}