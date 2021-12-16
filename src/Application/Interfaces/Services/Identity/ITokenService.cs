using JPBlazor.Application.Interfaces.Common;
using JPBlazor.Application.Requests.Identity;
using JPBlazor.Application.Responses.Identity;
using JPBlazor.Shared.Wrapper;
using System.Threading.Tasks;

namespace JPBlazor.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}