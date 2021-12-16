using JPBlazor.Application.Interfaces.Common;
using JPBlazor.Application.Requests.Identity;
using JPBlazor.Shared.Wrapper;
using System.Threading.Tasks;

namespace JPBlazor.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}