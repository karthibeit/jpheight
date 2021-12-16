using System.Collections.Generic;
using System.Threading.Tasks;
using JPBlazor.Application.Interfaces.Common;
using JPBlazor.Application.Requests.Identity;
using JPBlazor.Application.Responses.Identity;
using JPBlazor.Shared.Wrapper;

namespace JPBlazor.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}