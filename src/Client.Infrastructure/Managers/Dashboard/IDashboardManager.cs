using JPBlazor.Shared.Wrapper;
using System.Threading.Tasks;
using JPBlazor.Application.Features.Dashboards.Queries.GetData;

namespace JPBlazor.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}