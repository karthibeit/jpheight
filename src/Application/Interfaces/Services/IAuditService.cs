using JPBlazor.Application.Responses.Audit;
using JPBlazor.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JPBlazor.Application.Interfaces.Services
{
    public interface IAuditService
    {
        Task<IResult<IEnumerable<AuditResponse>>> GetCurrentUserTrailsAsync(string userId);

        Task<IResult<string>> ExportToExcelAsync(string userId, string searchString = "", bool searchInOldValues = false, bool searchInNewValues = false);
    }
}