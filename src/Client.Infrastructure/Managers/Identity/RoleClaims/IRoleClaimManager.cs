using System.Collections.Generic;
using System.Threading.Tasks;
using JPBlazor.Application.Requests.Identity;
using JPBlazor.Application.Responses.Identity;
using JPBlazor.Shared.Wrapper;

namespace JPBlazor.Client.Infrastructure.Managers.Identity.RoleClaims
{
    public interface IRoleClaimManager : IManager
    {
        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsAsync();

        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsByRoleIdAsync(string roleId);

        Task<IResult<string>> SaveAsync(RoleClaimRequest role);

        Task<IResult<string>> DeleteAsync(string id);
    }
}